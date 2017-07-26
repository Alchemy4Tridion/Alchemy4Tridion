using System;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public class ElevatedPrivilegesScope : IDisposable
	{
		private readonly ISessionAwareCoreService _client;

		public ElevatedPrivilegesScope(ISessionAwareCoreService client, Privileges privileges)
		{
			this._client = client;
			this._client.ElevatePrivileges(privileges);
		}

		public void Dispose()
		{
			this._client.RestorePrivileges();
		}
	}
}
