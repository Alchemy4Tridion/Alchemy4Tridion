using Alchemy4Tridion.Plugins.Clients.CoreService;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using Alchemy4Tridion.Plugins.Models;

namespace Alchemy4Tridion.Plugins.Clients
{
    public class AlchemyClients : IDisposable
    {
        private readonly string _currentUser;

        private readonly ImpersonationUserModel _impersonationUserModel;

        private IAlchemyCoreServiceClient _sessionAwareCoreServiceClient;

        private IAlchemyStreamUpload _sessionAwareCoreServiceUploadClient;

        private IAlchemyStreamDownload _sessionAwareCoreServiceDownloadClient;

        public AlchemyClients() { }

        public AlchemyClients(string currentUser)
        {
            this._currentUser = currentUser;
        }

        public AlchemyClients(string currentUser, SessionAwareCoreServiceEndPoint endPoint)
        {
            this._currentUser = currentUser;
            this.CoreServiceEndPoint = endPoint;
        }

        public AlchemyClients(string currentUser, SessionAwareCoreServiceEndPoint endPoint, ImpersonationUserModel impersonationUserModel)
        {
            this._currentUser = currentUser;
            this.CoreServiceEndPoint = endPoint;
            this._impersonationUserModel = impersonationUserModel;
        }

        public bool IsImpersonationUserSet()
        {
            return !string.IsNullOrEmpty(_impersonationUserModel?.Username) && !string.IsNullOrEmpty(this._impersonationUserModel.Password);
        }

        /// <summary>
        /// The default session aware core service endpoint to use.
        /// </summary>
        private SessionAwareCoreServiceEndPoint CoreServiceEndPoint { get; }

        /// <summary>
        /// Gets a session aware core service client that can be used for scope duration.  Uses the CoreServiceEndPoint to open.
        /// </summary>
        public IAlchemyCoreServiceClient SessionAwareCoreServiceClient
        {
            get
            {
                if (this._sessionAwareCoreServiceClient == null)
                {
                    this._sessionAwareCoreServiceClient = CreateSessionAwareCoreServiceClient(CoreServiceEndPoint);
                }
                return this._sessionAwareCoreServiceClient;
            }
        }

        public IAlchemyStreamUpload SessionAwareCoreServiceUploadClient
        {
            get
            {
                if (this._sessionAwareCoreServiceUploadClient == null)
                {
                    this._sessionAwareCoreServiceUploadClient = CreateSessionAwareCoreServiceUploadClient(CoreServiceEndPoint);
                }

                return this._sessionAwareCoreServiceUploadClient;
            }
        }

        public IAlchemyStreamDownload SessionAwareCoreServiceDownloadClient
        {
            get
            {
                if (this._sessionAwareCoreServiceDownloadClient == null)
                {
                    this._sessionAwareCoreServiceDownloadClient = CreateSessionAwareCoreServiceDownloadClient(_impersonationUserModel, CoreServiceEndPoint);
                }

                return this._sessionAwareCoreServiceDownloadClient;
            }
        }

        /// <summary>
        /// Get the Content Manager version in an enum.
        /// </summary>
        /// <returns></returns>
        public TridionVersionsEnum GetContentManagerVersion()
        {
            switch (this.CoreServiceEndPoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return TridionVersionsEnum.Web8;
                case SessionAwareCoreServiceEndPoint.NetTcp201603:
                    return TridionVersionsEnum.Web85;
                default:
                    return TridionVersionsEnum.Tridion2013SP1;
            }
        }

        public IAlchemyCoreServiceClient CreateSessionAwareCoreServiceClient(SessionAwareCoreServiceEndPoint endpoint)
        {
            switch (endpoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    var client201501 = new AlchemyCoreServiceClient201501();
                    client201501.Impersonate(this._currentUser);
                    return client201501;
                case SessionAwareCoreServiceEndPoint.NetTcp201603:
                    var client201603 = new AlchemyCoreServiceClient201603();
                    client201603.Impersonate(this._currentUser);
                    return client201603;
                default:
                    var client2013 = new AlchemyCoreServiceClient2013();
                    client2013.Impersonate(this._currentUser);
                    return client2013;
            }
        }

        public IAlchemyStreamDownload CreateSessionAwareCoreServiceDownloadClient(ImpersonationUserModel impersonationUserModel, SessionAwareCoreServiceEndPoint endpoint)
        {
            switch (endpoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return new AlchemyStreamDownloadClient201501(impersonationUserModel);
                case SessionAwareCoreServiceEndPoint.NetTcp201603:
                    return new AlchemyStreamDownloadClient201603(impersonationUserModel);
                default:
                    return new AlchemyStreamDownloadClient201501(impersonationUserModel);
            }

        }

        public IAlchemyStreamUpload CreateSessionAwareCoreServiceUploadClient(SessionAwareCoreServiceEndPoint endpoint)
        {
            switch (endpoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return new AlchemyStreamUploadClient201501();
                case SessionAwareCoreServiceEndPoint.NetTcp201603:
                    return new AlchemyStreamUploadClient201603();
                default:
                    return new AlchemyStreamUploadClient201501();
            }
        }

        public void Dispose()
        {
            _sessionAwareCoreServiceClient?.Dispose();
            _sessionAwareCoreServiceUploadClient?.Dispose();
            _sessionAwareCoreServiceDownloadClient?.Dispose();
        }
    }
}
