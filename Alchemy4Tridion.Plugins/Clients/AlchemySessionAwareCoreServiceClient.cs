using System;
using System.ServiceModel;
using Tridion.ContentManager.CoreService.Client;

namespace Alchemy4Tridion.Plugins.Clients
{
    /// <summary>
    /// Represents possible end points for a core service client.
    /// </summary>
    public enum SessionAwareCoreServiceEndPoint
    {
        NetTcp2011,
        NetTcp2012,
        NetTcp2013,
        /**
         * SDL Web 8 end point
         */
        NetTcp201501
    }

    /// <summary>
    /// Provides a wrapper of the Tridion SessionAwareCoreServiceClient using a safe implementation of IDisposable.
    /// You can use this client inside of a using statement, and calling its Close or Dispose method will safely
    /// close out the 
    /// </summary>
    /// <remarks>
    /// Shoutout to Eric Huiza (http://erichuiza.blogspot.com/2013/12/how-to-correctly-dispose-coreservice.html)
    /// </remarks>
    public class AlchemySessionAwareCoreServiceClient : SessionAwareCoreServiceClient, IDisposable
    {
        /// <summary>
        /// Whether or not the dispose method has already been called.
        /// </summary>
        private bool isDisposed = false;


        /// <summary>
        /// Gets which entpoint was used to create this core service client.
        /// </summary>
        public SessionAwareCoreServiceEndPoint? ClientEndpoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the name of the user that the client was last impersonated with using the Impersonate method.
        /// </summary>
        public string ImpersonatedUsername
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using a default endpoint config name of netTcp_2013
        /// </summary>
        public AlchemySessionAwareCoreServiceClient()
            : this(SessionAwareCoreServiceEndPoint.NetTcp2013)
        {

        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using the supplied endpoint.
        /// </summary>
        /// <param name="endPoint"></param>
        public AlchemySessionAwareCoreServiceClient(SessionAwareCoreServiceEndPoint endPoint)
            : base(GetEnpointConfigurationName(endPoint))
        {
            ClientEndpoint = endPoint;
        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using the supplied end point configuration name (ie "netTcp_2013").
        /// </summary>
        /// <param name="endPointConfigurationName"></param>
        public AlchemySessionAwareCoreServiceClient(string endPointConfigurationName)
            : base(endPointConfigurationName)
        {

        }

        /// <summary>
        /// Gets the endpoint configuration name, defaulting to "netTcp_2013".
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        private static string GetEnpointConfigurationName(SessionAwareCoreServiceEndPoint endPoint)
        {
            switch (endPoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp2011:
                    return "netTcp_2011";
                case SessionAwareCoreServiceEndPoint.NetTcp2012:
                    return "netTcp_2012";
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return "netTcp_201501";
                default:
                    return "netTcp_2013";
            }
        }

        /// <summary>
        /// Hides the underlying client and calls the Dispose method.
        /// </summary>
        public new void Close()
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
            if (!this.isDisposed && disposing)
            {
                this.isDisposed = true;

                try
                {
                    if (State != CommunicationState.Closed)
                    {
                        base.Close();
                    }
                }
                catch (CommunicationException ex)
                {
                    Abort(); //The channel is aborted and the resources released.
                }
                catch (TimeoutException ex)
                {
                    Abort(); //The channel is aborted and the resources released.
                }
                catch (Exception ex)
                {
                    Abort(); // The channel is aborted and the resources released.
                }
            }
        }

        /// <summary>
        /// Impersonates the client as the given account username. Sets the ImpersonatedUsername as a reference
        /// to the last username that was impersonated.
        /// </summary>
        /// <param name="username">The account username.</param>
        /// <returns></returns>
        public new UserData Impersonate(string username)
        {
            ImpersonatedUsername = username;

            return base.Impersonate(username);
        }

        /// <summary>
        /// Finalizer
        /// </summary>
        ~AlchemySessionAwareCoreServiceClient()
        {
            Dispose(false);
        }
    }
}