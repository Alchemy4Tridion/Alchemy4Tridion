using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Security.Claims;
using System.Security.Principal;
using System.ServiceModel.Description;
using System.Threading;

namespace Alchemy4Tridion.Plugins.Clients.CoreService.Security
{
	public class ClaimsClientCredentials : ClientCredentials
	{
		private IEnumerable<Claim> _claims;

		public IEnumerable<Claim> Claims
		{
			get
			{
				if (this._claims == null)
				{
					this.CreateUserNameClaims();
				}
				return this._claims;
			}
			set
			{
				this._claims = value;
			}
		}

		public IEnumerable<Uri> AudienceUris
		{
			get;
			set;
		}

		public ClaimsClientCredentials()
		{
			base.SupportInteractive = false;
		}

		protected override ClientCredentials CloneCore()
		{
			return (ClientCredentials)base.MemberwiseClone();
		}

		public override SecurityTokenManager CreateSecurityTokenManager()
		{
			return new SamlSecurityTokenManager(this);
		}

		private void CreateUserNameClaims()
		{
			string value = base.UserName.UserName;
			if (string.IsNullOrEmpty(value))
			{
				value = base.Windows.ClientCredential.UserName;
			}
			if (string.IsNullOrEmpty(value))
			{
				value = Thread.CurrentPrincipal.Identity.Name;
			}
			if (string.IsNullOrEmpty(value))
			{
				value = WindowsIdentity.GetCurrent().Name;
			}
			Claim claim = new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", value);
			this._claims = new Claim[]
			{
				claim
			};
		}
	}
}
