using System;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public static class ApplicationDataUtilities
	{
		public static T GetAs<T>(this ApplicationData target)
		{
			ApplicationDataAdapter applicationDataAdapter = new ApplicationDataAdapter(target);
			return applicationDataAdapter.GetAs<T>();
		}
	}
}
