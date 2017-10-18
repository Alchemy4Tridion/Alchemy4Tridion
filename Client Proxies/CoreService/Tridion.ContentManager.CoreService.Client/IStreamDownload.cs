using System;
using System.CodeDom.Compiler;
using System.IO;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", ConfigurationName = "Tridion.ContentManager.CoreService.Client.IStreamDownload", SessionMode = SessionMode.NotAllowed)]
	public interface IStreamDownload
	{
		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentResponse")]
		Stream DownloadBinaryContent(string itemIdOrTempFileId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentResponse")]
		IAsyncResult BeginDownloadBinaryContent(string itemIdOrTempFileId, AsyncCallback callback, object asyncState);

		Stream EndDownloadBinaryContent(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentByUserCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentByUser", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentByUserResponse")]
		Stream DownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentByUser", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadBinaryContentByUserResponse")]
		IAsyncResult BeginDownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken, AsyncCallback callback, object asyncState);

		Stream EndDownloadBinaryContentByUser(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadRenderedBinaryCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadRenderedBinary", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadRenderedBinaryResponse")]
		Stream DownloadRenderedBinary(string path);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadRenderedBinary", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadRenderedBinaryResponse")]
		IAsyncResult BeginDownloadRenderedBinary(string path, AsyncCallback callback, object asyncState);

		Stream EndDownloadRenderedBinary(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadExternalBinaryContentCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadExternalBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadExternalBinaryContentResponse")]
		Stream DownloadExternalBinaryContent(string uri);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadExternalBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamDownload/DownloadExternalBinaryContentResponse")]
		IAsyncResult BeginDownloadExternalBinaryContent(string uri, AsyncCallback callback, object asyncState);

		Stream EndDownloadExternalBinaryContent(IAsyncResult result);
	}
}
