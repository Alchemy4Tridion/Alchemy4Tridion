using System;
using System.IO;
using System.ServiceModel;


namespace Alchemy4Tridion.Plugins.Clients.CoreService 
{
	public class AlchemyStreamUploadClient201501 : IAlchemyStreamUpload, IDisposable
	{
         
        public IStreamUpload201501 Channel { get; set; }

        /// <summary>
        /// Whether or not the dispose method has already been called.
        /// </summary>
        private bool _isDisposed = false;

        public AlchemyStreamUploadClient201501()
        {
            var factory = new ChannelFactory<IStreamUpload201501>("streamUpload_netTcp_201501");
            Channel = factory.CreateChannel();
        }

        /// <summary>
        /// Gets which entpoint was used to create this core service client.
        /// </summary>
        public SessionAwareCoreServiceEndPoint? ClientEndpoint
        {
            get;
            private set;
        }

        IUploadResponse IAlchemyStreamUpload.UploadBinaryContent(IUploadRequest request)
		{
			return Channel.UploadBinaryContent((UploadRequest201501) request);
		}

        public string UploadBinaryContent(AccessTokenData AccessToken, Stream UploadContent)
        {
            return Channel.UploadBinaryContent(new UploadRequest201501
            {
                AccessToken = AccessToken,
                UploadContent = UploadContent
            }).FilePath;
		}
		
		public string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data)
		{
			return Channel.UploadBinaryByteArray(accessToken, data);
		}

	
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
                IStreamUploadChannel channel = (IStreamUploadChannel) Channel;
                if (!this._isDisposed && disposing)
                {
                    this._isDisposed = true;

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
