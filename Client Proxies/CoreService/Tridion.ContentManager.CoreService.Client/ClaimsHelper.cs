using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public static class ClaimsHelper
	{
		private const string TridionDirectoryServiceName = "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName";

		public static IEnumerable<ClaimData> ToClaimSetData(this IEnumerable<Claim> claims)
		{
			List<ClaimData> list = (from c in claims
			select new ClaimData
			{
				Type = c.Type,
				Value = c.Value
			}).ToList<ClaimData>();
			if (claims.SingleOrDefault((Claim c) => c.Type == "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName") == null)
			{
				Claim claim = claims.FirstOrDefault((Claim c) => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
				if (claim != null && !string.IsNullOrEmpty(claim.Issuer))
				{
					list.Add(new ClaimData
					{
						Type = "http://www.tridion.com/2009/08/directoryservice/claims/directoryServiceName",
						Value = claim.Issuer
					});
				}
			}
			return list;
		}
	}
}
