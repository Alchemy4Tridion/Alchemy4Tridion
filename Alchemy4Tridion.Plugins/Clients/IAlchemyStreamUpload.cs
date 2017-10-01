using System;
using System.CodeDom.Compiler;
using System.IO;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", ConfigurationName = "Tridion.ContentManager.CoreService.Client.IStreamUpload", SessionMode = SessionMode.NotAllowed)]
	public interface IAlchemyStreamUpload
	{
		UploadResponse UploadBinaryContent(UploadRequest request);
	    string UploadBinaryContent(AccessTokenData AccessToken, Stream UploadContent);
        string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data);
        void Dispose();
    }
}
