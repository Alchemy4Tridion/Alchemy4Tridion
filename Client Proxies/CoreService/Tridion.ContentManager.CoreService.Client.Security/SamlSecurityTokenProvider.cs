using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;

namespace Alchemy4Tridion.Plugins.Clients.CoreService.Security
{
	internal abstract class SamlSecurityTokenProvider : SecurityTokenProvider
	{
		protected const string DirectoryServiceNameClaimType = "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName";

		protected ClaimsClientCredentials ClientCredentials
		{
			get;
			private set;
		}

		protected SecurityTokenRequirement TokenRequirement
		{
			get;
			private set;
		}

		protected SecurityAlgorithmSuite SecurityAlgorithmSuite
		{
			get;
			private set;
		}

		protected TimeSpan TokenValidityTimeSpan
		{
			get;
			private set;
		}

		internal SamlSecurityTokenProvider(ClaimsClientCredentials clientCredentials, SecurityTokenRequirement tokenRequirement, SecurityAlgorithmSuite securityAlgorithmSuite)
		{
			this.ClientCredentials = clientCredentials;
			this.TokenRequirement = tokenRequirement;
			this.SecurityAlgorithmSuite = securityAlgorithmSuite;
			this.TokenValidityTimeSpan = TimeSpan.FromHours(1.0);
		}

		protected static SecurityToken CreateSymmetricProofToken(int keySize)
		{
			if (keySize < 128 || keySize > 2048)
			{
				throw new ArgumentOutOfRangeException("keySize", "must be in the range 128 to 2048");
			}
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			byte[] array = new byte[keySize / 8];
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
			return new BinarySecretSecurityToken(array);
		}

		protected static SecurityToken CreateAsymmetricProofToken()
		{
			return new RsaSecurityToken(RSA.Create());
		}
	}
}
