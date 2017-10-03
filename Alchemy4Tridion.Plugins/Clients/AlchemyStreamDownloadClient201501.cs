using System;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading.Tasks;
using Alchemy4Tridion.Plugins.Models;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public class AlchemyStreamDownloadClient201501 : IAlchemyStreamDownload, IDisposable
	{

        /// <summary>
        /// Whether or not the dispose method has already been called.
        /// </summary>
        private bool isDisposed = false;

        /// <summary>
        /// 
        /// </summary>
        public IStreamDownload201501 Channel { get; set; }


        public AlchemyStreamDownloadClient201501(ImpersonationUserModel impersonationUserModel)
        {
            var factory = new ChannelFactory<IStreamDownload201501>("streamDownload_netTcp_201501");
            factory.Credentials.Windows.ClientCredential = new NetworkCredential(impersonationUserModel.Username, impersonationUserModel.Password);
            factory.Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
            Channel = factory.CreateChannel(); 

        }

        #region CoreService Methods 

        public Stream DownloadBinaryContent(string itemIdOrTempFileId)
		{
			return Channel.DownloadBinaryContent(itemIdOrTempFileId);
		}

	
		public async Task<Stream> DownloadBinaryContentAsync(string itemIdOrTempFileId)
		{
            return await Task<Stream>.Factory.FromAsync(Channel.BeginDownloadBinaryContent, Channel.EndDownloadBinaryContent, itemIdOrTempFileId, null);
		}

		public Stream DownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken)
		{
			return Channel.DownloadBinaryContentByUser(itemIdOrTempFileId, accessToken);
		}

		public async Task<Stream> DownloadBinaryContentByUserAsync(string itemIdOrTempFileId, AccessTokenData accessToken)
		{
            return await Task<Stream>.Factory.FromAsync(Channel.BeginDownloadBinaryContentByUser, Channel.EndDownloadBinaryContentByUser, itemIdOrTempFileId, accessToken, null);
        }


		public Stream DownloadRenderedBinary(string path)
		{
			return Channel.DownloadRenderedBinary(path);
		}

		
		public async Task<Stream> DownloadRenderedBinaryAsync(string path)
		{
            return await Task<Stream>.Factory.FromAsync(Channel.BeginDownloadRenderedBinary, Channel.EndDownloadRenderedBinary, path, null);
        }


		public Stream DownloadExternalBinaryContent(string uri)
		{
			return Channel.DownloadExternalBinaryContent(uri);
		}

		
		public async Task<Stream> DownloadExternalBinaryContentAsync(string uri)
		{
            return await Task<Stream>.Factory.FromAsync(Channel.BeginDownloadExternalBinaryContent, Channel.EndDownloadExternalBinaryContent, uri, null);
		}

        #endregion


        /// <summary>
        /// Calls the dispose method.
        /// </summary>
        public void Close()
        {
            Dispose(true);
        }

        /// <summary>
        /// Implements IDisposable and disposes of the WCF client in a safe manner.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Disposes the client in a safe manner.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (Channel != null)
            {
                IStreamDownloadChannel channel = (IStreamDownloadChannel) Channel;
                if (!this.isDisposed && disposing)
                {
                    this.isDisposed = true;

                    try
                    {
                        if (channel.State != CommunicationState.Closed)
                        {
                            channel.Close();
                        }
                    }
                    catch (CommunicationException ex)
                    {
                        channel.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (TimeoutException ex)
                    {
                        channel.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (Exception ex)
                    {
                        channel.Abort(); // The channel is aborted and the resources released.
                    }
                }
            }
        }
    }
}
