using System;
using System.CodeDom.Compiler;
using System.IO;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public interface IAlchemyStreamUpload
	{
		UploadResponse UploadBinaryContent(UploadRequest request);
	    string UploadBinaryContent(AccessTokenData AccessToken, Stream UploadContent);
        string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data);
        void Dispose();
    }
}
