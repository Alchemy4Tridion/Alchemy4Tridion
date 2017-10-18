using System;
using System.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public static class AccessTokenDataExtensions
	{
		public static bool IsSystemAdministrator(this AccessTokenData accessToken)
		{
			return (accessToken.Privileges & 1) != 0 || accessToken.HasSystemPrivilege("tcm:SystemAdministration");
		}

		public static bool HasSystemPrivilege(this AccessTokenData accessToken, string privilegeKey = "tcm:SystemAdministration")
		{
			return accessToken.InheritedSystemPrivileges != null && accessToken.InheritedSystemPrivileges.Keys.Any((SystemPrivilege sysPriv) => sysPriv.Key == privilegeKey || sysPriv.Key == "tcm:SystemAdministration");
		}
	}
}
