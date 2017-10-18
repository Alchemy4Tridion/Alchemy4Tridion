using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", ConfigurationName = "Alchemy4Tridion.Plugins.Clients.CoreService.IStreamUpload201501", SessionMode = SessionMode.NotAllowed)]
    public interface IStreamUpload201501
	{
        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryContentCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryContentResponse")]
        UploadResponse UploadBinaryContent(UploadRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryContent", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryContentResponse")]
        IAsyncResult BeginUploadBinaryContent(UploadRequest request, AsyncCallback callback, object asyncState);

        UploadResponse EndUploadBinaryContent(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryByteArrayCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryByteArray", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryByteArrayResponse")]
        string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryByteArray", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/IStreamUpload/UploadBinaryByteArrayResponse")]
        IAsyncResult BeginUploadBinaryByteArray(AccessTokenData accessToken, byte[] data, AsyncCallback callback, object asyncState);

        string EndUploadBinaryByteArray(IAsyncResult result);
    }
}
