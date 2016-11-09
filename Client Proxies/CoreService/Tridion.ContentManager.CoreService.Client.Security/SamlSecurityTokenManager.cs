using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;

namespace Alchemy4Tridion.Plugins.Clients.CoreService.Security
{
	internal class SamlSecurityTokenManager : ClientCredentialsSecurityTokenManager
	{
		private readonly ClaimsClientCredentials _claimsClientCredentials;

		internal SamlSecurityTokenManager(ClaimsClientCredentials claimsClientCredentials) : base(claimsClientCredentials)
		{
			this._claimsClientCredentials = claimsClientCredentials;
		}

		public override SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement tokenRequirement)
		{
			if (tokenRequirement.TokenType == SecurityTokenTypes.Saml || tokenRequirement.TokenType == "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV1.1")
			{
				this.AssertClaimsNotNull();
				return new Saml11SecurityTokenProvider(this._claimsClientCredentials, tokenRequirement, SamlSecurityTokenManager.GetSecurityAlgorithmSuite(tokenRequirement));
			}
			if (tokenRequirement.TokenType == "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV2.0")
			{
				this.AssertClaimsNotNull();
				return new Saml20SecurityTokenProvider(this._claimsClientCredentials, tokenRequirement, SamlSecurityTokenManager.GetSecurityAlgorithmSuite(tokenRequirement));
			}
			return base.CreateSecurityTokenProvider(tokenRequirement);
		}

		private static SecurityAlgorithmSuite GetSecurityAlgorithmSuite(SecurityTokenRequirement tokenRequirement)
		{
			SecurityAlgorithmSuite result = null;
			SecurityBindingElement securityBindingElement;
			if (tokenRequirement.TryGetProperty<SecurityBindingElement>("http://schemas.microsoft.com/ws/2006/05/servicemodel/securitytokenrequirement/SecurityBindingElement", out securityBindingElement))
			{
				result = securityBindingElement.DefaultAlgorithmSuite;
			}
			return result;
		}

		private void AssertClaimsNotNull()
		{
			if (this._claimsClientCredentials.Claims == null)
			{
				throw new ArgumentNullException("ClaimsClientCredentials.Claims");
			}
		}
	}
}
