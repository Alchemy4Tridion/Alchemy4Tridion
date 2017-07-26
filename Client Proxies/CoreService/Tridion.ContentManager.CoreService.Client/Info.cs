using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "Info", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(BluePrintInfo)), KnownType(typeof(LocationInfo)), KnownType(typeof(PublishLocationInfo)), KnownType(typeof(LockInfo)), KnownType(typeof(DynamicVersionInfo)), KnownType(typeof(BasicVersionInfo)), KnownType(typeof(LimitedVersionInfo)), KnownType(typeof(FullVersionInfo)), KnownType(typeof(WorkflowInfo)), KnownType(typeof(PublishInfoData)), KnownType(typeof(ListInfo)), KnownType(typeof(WhereUsedListInfo)), KnownType(typeof(ProcessDefinitionAssociationListInfo)), KnownType(typeof(ProcessInstanceListInfo)), KnownType(typeof(WorkItemListInfo)), KnownType(typeof(PublishTransactionListInfo)), KnownType(typeof(ContainingBundlesListInfo))]
	public class Info : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}
	}
}
