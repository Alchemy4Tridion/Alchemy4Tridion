using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Xml;

namespace Alchemy4Tridion.Plugins.Clients.CoreService.Security
{
	internal class Saml11SecurityTokenProvider : SamlSecurityTokenProvider
	{
		internal Saml11SecurityTokenProvider(ClaimsClientCredentials claimsClientCredentials, SecurityTokenRequirement tokenRequirement, SecurityAlgorithmSuite securityAlgorithmSuite) : base(claimsClientCredentials, tokenRequirement, securityAlgorithmSuite)
		{
		}

		private SamlAssertion CreateSamlAssertionWithAsymmetricKey(SecurityToken proofToken)
		{
			X509SecurityToken x509SecurityToken = new X509SecurityToken(base.ClientCredentials.ClientCertificate.Certificate);
			SecurityKey signatureKey = x509SecurityToken.SecurityKeys[0];
			SecurityKeyIdentifierClause securityKeyIdentifierClause = x509SecurityToken.CreateKeyIdentifierClause<X509ThumbprintKeyIdentifierClause>();
			SecurityKeyIdentifier signatureKeyIdentifier = new SecurityKeyIdentifier(new SecurityKeyIdentifierClause[]
			{
				securityKeyIdentifierClause
			});
			SecurityKeyIdentifier proofKeyIdentifier = new SecurityKeyIdentifier(new SecurityKeyIdentifierClause[]
			{
				proofToken.CreateKeyIdentifierClause<RsaKeyIdentifierClause>()
			});
			return this.CreateSamlAssertion(signatureKey, signatureKeyIdentifier, proofKeyIdentifier);
		}

		private SamlAssertion CreateSamlAssertionWithSymmetricKey(BinarySecretSecurityToken proofToken)
		{
			X509SecurityToken x509SecurityToken = new X509SecurityToken(base.ClientCredentials.ClientCertificate.Certificate);
			X509SecurityToken x509SecurityToken2 = new X509SecurityToken(base.ClientCredentials.ServiceCertificate.DefaultCertificate);
			SecurityKey signatureKey = x509SecurityToken.SecurityKeys[0];
			SecurityKeyIdentifierClause securityKeyIdentifierClause = x509SecurityToken.CreateKeyIdentifierClause<X509ThumbprintKeyIdentifierClause>();
			SecurityKeyIdentifier signatureKeyIdentifier = new SecurityKeyIdentifier(new SecurityKeyIdentifierClause[]
			{
				securityKeyIdentifierClause
			});
			SecurityKey securityKey = x509SecurityToken2.SecurityKeys[0];
			SecurityKeyIdentifierClause securityKeyIdentifierClause2 = x509SecurityToken2.CreateKeyIdentifierClause<X509ThumbprintKeyIdentifierClause>();
			SecurityKeyIdentifier encryptingKeyIdentifier = new SecurityKeyIdentifier(new SecurityKeyIdentifierClause[]
			{
				securityKeyIdentifierClause2
			});
			byte[] keyBytes = proofToken.GetKeyBytes();
			byte[] encryptedKey = securityKey.EncryptKey(base.SecurityAlgorithmSuite.DefaultAsymmetricKeyWrapAlgorithm, keyBytes);
			SecurityKeyIdentifier proofKeyIdentifier = new SecurityKeyIdentifier(new SecurityKeyIdentifierClause[]
			{
				new EncryptedKeyIdentifierClause(encryptedKey, base.SecurityAlgorithmSuite.DefaultAsymmetricKeyWrapAlgorithm, encryptingKeyIdentifier)
			});
			return this.CreateSamlAssertion(signatureKey, signatureKeyIdentifier, proofKeyIdentifier);
		}

		private SamlAssertion CreateSamlAssertion(SecurityKey signatureKey, SecurityKeyIdentifier signatureKeyIdentifier, SecurityKeyIdentifier proofKeyIdentifier)
		{
			Claim claim = base.ClientCredentials.Claims.FirstOrDefault((Claim c) => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
			if (claim == null)
			{
				throw new ArgumentException("At least one NameIdentifier/Identity claim must be present in the claimset", "ClaimsClientCredentials.Claims");
			}
			SamlSubject samlSubject = new SamlSubject
			{
				NameFormat = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
				Name = claim.Value,
				KeyIdentifier = proofKeyIdentifier
			};
			samlSubject.ConfirmationMethods.Add(SamlConstants.HolderOfKey);
			IEnumerable<SamlAttribute> enumerable = from c in base.ClientCredentials.Claims.Except(new Claim[]
			{
				claim
			})
			select new SamlAttribute(SamlConstants.Namespace, c.Type, new string[]
			{
				c.Value
			});
			if (base.ClientCredentials.Claims.FirstOrDefault((Claim c) => c.Type == "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName") == null)
			{
				SamlAttribute samlAttribute = new SamlAttribute(SamlConstants.Namespace, "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName", new string[]
				{
					claim.Issuer
				});
				enumerable = enumerable.Concat(new SamlAttribute[]
				{
					samlAttribute
				});
			}
			DateTime utcNow = DateTime.UtcNow;
			SamlAssertion samlAssertion = new SamlAssertion
			{
				AssertionId = "_" + Guid.NewGuid(),
				Issuer = claim.Issuer,
				IssueInstant = utcNow,
				Advice = new SamlAdvice(),
				SigningCredentials = new SigningCredentials(signatureKey, base.SecurityAlgorithmSuite.DefaultAsymmetricSignatureAlgorithm, base.SecurityAlgorithmSuite.DefaultDigestAlgorithm, signatureKeyIdentifier)
			};
			samlAssertion.Statements.Add(new SamlAttributeStatement(samlSubject, enumerable));
			if (base.ClientCredentials.AudienceUris != null)
			{
				IEnumerable<SamlCondition> conditions = new SamlAudienceRestrictionCondition[]
				{
					new SamlAudienceRestrictionCondition(base.ClientCredentials.AudienceUris)
				};
				samlAssertion.Conditions = new SamlConditions(utcNow, utcNow + base.TokenValidityTimeSpan, conditions);
			}
			else
			{
				samlAssertion.Conditions = new SamlConditions(utcNow, utcNow + base.TokenValidityTimeSpan);
			}
			return samlAssertion;
		}

		protected override SecurityToken GetTokenCore(TimeSpan timeout)
		{
			SecurityToken securityToken;
			SamlAssertion samlAssertion;
			if (base.TokenRequirement.KeyType == SecurityKeyType.SymmetricKey)
			{
				securityToken = SamlSecurityTokenProvider.CreateSymmetricProofToken(base.TokenRequirement.KeySize);
				samlAssertion = this.CreateSamlAssertionWithSymmetricKey((BinarySecretSecurityToken)securityToken);
			}
			else
			{
				if (base.TokenRequirement.KeyType != SecurityKeyType.AsymmetricKey)
				{
					throw new ArgumentOutOfRangeException("KeyType");
				}
				securityToken = SamlSecurityTokenProvider.CreateAsymmetricProofToken();
				samlAssertion = this.CreateSamlAssertionWithAsymmetricKey(securityToken);
			}
			SamlSecurityToken samlSecurityToken = new SamlSecurityToken(samlAssertion);
			XmlDocument xmlDocument = new XmlDocument();
			using (XmlWriter xmlWriter = xmlDocument.CreateNavigator().AppendChild())
			{
				WSSecurityTokenSerializer wSSecurityTokenSerializer = new WSSecurityTokenSerializer();
				wSSecurityTokenSerializer.WriteToken(xmlWriter, samlSecurityToken);
			}
			SamlAssertionKeyIdentifierClause samlAssertionKeyIdentifierClause = samlSecurityToken.CreateKeyIdentifierClause<SamlAssertionKeyIdentifierClause>();
			return new GenericXmlSecurityToken(xmlDocument.DocumentElement, securityToken, samlAssertion.Conditions.NotBefore, samlAssertion.Conditions.NotOnOrAfter, samlAssertionKeyIdentifierClause, samlAssertionKeyIdentifierClause, null);
		}
	}
}
