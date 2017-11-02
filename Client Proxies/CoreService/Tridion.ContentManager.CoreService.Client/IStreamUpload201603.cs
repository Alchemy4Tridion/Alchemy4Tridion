using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", ConfigurationName = "Alchemy4Tridion.Plugins.Clients.CoreService.IStreamUpload201603", SessionMode = SessionMode.NotAllowed)]
	public interface IStreamUpload201603
	{
        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryContentCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryContentResponse")]
        UploadResponse201603 UploadBinaryContent(UploadRequest201603 request);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryContentResponse")]
        IAsyncResult BeginUploadBinaryContent(UploadRequest201603 request, AsyncCallback callback, object asyncState);

        UploadResponse201603 EndUploadBinaryContent(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryByteArrayCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryByteArray", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryByteArrayResponse")]
        string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryByteArray", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/IStreamUpload/UploadBinaryByteArrayResponse")]
        IAsyncResult BeginUploadBinaryByteArray(AccessTokenData accessToken, byte[] data, AsyncCallback callback, object asyncState);

        string EndUploadBinaryByteArray(IAsyncResult result);
    }
}
