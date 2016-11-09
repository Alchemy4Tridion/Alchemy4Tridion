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
	internal class Saml20SecurityTokenProvider : SamlSecurityTokenProvider
	{
		internal Saml20SecurityTokenProvider(ClaimsClientCredentials claimsClientCredentials, SecurityTokenRequirement tokenRequirement, SecurityAlgorithmSuite securityAlgorithmSuite) : base(claimsClientCredentials, tokenRequirement, securityAlgorithmSuite)
		{
		}

		private Saml2Assertion CreateSamlAssertionWithAsymmetricKey(SecurityToken proofToken)
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

		private Saml2Assertion CreateSamlAssertionWithSymmetricKey(BinarySecretSecurityToken proofToken)
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

		private Saml2Assertion CreateSamlAssertion(SecurityKey signatureKey, SecurityKeyIdentifier signatureKeyIdentifier, SecurityKeyIdentifier proofKeyIdentifier)
		{
			Claim claim = base.ClientCredentials.Claims.FirstOrDefault((Claim c) => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
			if (claim == null)
			{
				throw new ArgumentException("At least one NameIdentifier/Identity claim must be present in the claimset", "ClaimsClientCredentials.Claims");
			}
			Saml2Subject saml2Subject = new Saml2Subject
			{
				NameId = new Saml2NameIdentifier(claim.Value, new Uri("urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified"))
			};
			Saml2SubjectConfirmationData saml2SubjectConfirmationData = new Saml2SubjectConfirmationData();
			saml2SubjectConfirmationData.KeyIdentifiers.Add(proofKeyIdentifier);
			saml2Subject.SubjectConfirmations.Add(new Saml2SubjectConfirmation(new Uri("urn:oasis:names:tc:SAML:2.0:cm:holder-of-key"), saml2SubjectConfirmationData));
			IEnumerable<Saml2Attribute> enumerable = from c in base.ClientCredentials.Claims.Except(new Claim[]
			{
				claim
			})
			select new Saml2Attribute(c.Type, c.Value);
			Claim claim2 = base.ClientCredentials.Claims.FirstOrDefault((Claim c) => c.Type == "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName");
			Saml2NameIdentifier issuer;
			if (claim2 == null)
			{
				Saml2Attribute saml2Attribute = new Saml2Attribute("http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName", claim.Issuer);
				enumerable = enumerable.Concat(new Saml2Attribute[]
				{
					saml2Attribute
				});
				issuer = new Saml2NameIdentifier(claim.Issuer);
			}
			else
			{
				issuer = new Saml2NameIdentifier(claim2.Value);
			}
			DateTime utcNow = DateTime.UtcNow;
			Saml2Assertion saml2Assertion = new Saml2Assertion(issuer)
			{
				Subject = saml2Subject,
				IssueInstant = utcNow,
				Conditions = new Saml2Conditions
				{
					NotBefore = new DateTime?(utcNow),
					NotOnOrAfter = new DateTime?(utcNow + base.TokenValidityTimeSpan)
				},
				Advice = new Saml2Advice(),
				SigningCredentials = new SigningCredentials(signatureKey, base.SecurityAlgorithmSuite.DefaultAsymmetricSignatureAlgorithm, base.SecurityAlgorithmSuite.DefaultDigestAlgorithm, signatureKeyIdentifier)
			};
			saml2Assertion.Statements.Add(new Saml2AttributeStatement(enumerable));
			if (base.ClientCredentials.AudienceUris != null)
			{
				saml2Assertion.Conditions.AudienceRestrictions.Add(new Saml2AudienceRestriction(base.ClientCredentials.AudienceUris));
			}
			return saml2Assertion;
		}

		protected override SecurityToken GetTokenCore(TimeSpan timeout)
		{
			SecurityToken securityToken;
			Saml2Assertion saml2Assertion;
			if (base.TokenRequirement.KeyType == SecurityKeyType.SymmetricKey)
			{
				securityToken = SamlSecurityTokenProvider.CreateSymmetricProofToken(base.TokenRequirement.KeySize);
				saml2Assertion = this.CreateSamlAssertionWithSymmetricKey((BinarySecretSecurityToken)securityToken);
			}
			else
			{
				if (base.TokenRequirement.KeyType != SecurityKeyType.AsymmetricKey)
				{
					throw new ArgumentOutOfRangeException("KeyType");
				}
				securityToken = SamlSecurityTokenProvider.CreateAsymmetricProofToken();
				saml2Assertion = this.CreateSamlAssertionWithAsymmetricKey(securityToken);
			}
			Saml2SecurityToken saml2SecurityToken = new Saml2SecurityToken(saml2Assertion);
			XmlDocument xmlDocument = new XmlDocument();
			using (XmlWriter xmlWriter = xmlDocument.CreateNavigator().AppendChild())
			{
				Saml2SecurityTokenHandler saml2SecurityTokenHandler = new Saml2SecurityTokenHandler();
				saml2SecurityTokenHandler.WriteToken(xmlWriter, saml2SecurityToken);
			}
			SamlAssertionKeyIdentifierClause samlAssertionKeyIdentifierClause = saml2SecurityToken.CreateKeyIdentifierClause<SamlAssertionKeyIdentifierClause>();
			return new GenericXmlSecurityToken(xmlDocument.DocumentElement, securityToken, saml2Assertion.Conditions.NotBefore.Value, saml2Assertion.Conditions.NotOnOrAfter.Value, samlAssertionKeyIdentifierClause, samlAssertionKeyIdentifierClause, null);
		}
	}
}
