using System;
using System.CodeDom.Compiler;
using System.IO;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public interface IAlchemyStreamDownload
	{
		Stream DownloadBinaryContent(string itemIdOrTempFileId);
		Stream DownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken);
		Stream DownloadRenderedBinary(string path);
		Stream DownloadExternalBinaryContent(string uri);
        void Dispose();
    }
}
