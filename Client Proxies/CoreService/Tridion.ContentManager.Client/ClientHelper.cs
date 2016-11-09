using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
    public static class ClientHelper
	{
		public static void DisposeClient(ICommunicationObject client)
		{
			if (client.State == CommunicationState.Faulted)
			{
				client.Abort();
				return;
			}
			try
			{
				client.Close();
			}
			catch
			{
				client.Abort();
			}
		}
	}
}
