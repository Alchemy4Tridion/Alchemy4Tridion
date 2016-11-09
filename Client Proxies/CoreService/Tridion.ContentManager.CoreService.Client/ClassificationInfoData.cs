using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ClassificationInfoData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ClassificationInfoData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ClassificationDetailData[] DetailsField;

		private RepositoryLocalObjectData ItemField;

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

		[DataMember(EmitDefaultValue = false)]
		public ClassificationDetailData[] Details
		{
			get
			{
				return this.DetailsField;
			}
			set
			{
				this.DetailsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RepositoryLocalObjectData Item
		{
			get
			{
				return this.ItemField;
			}
			set
			{
				this.ItemField = value;
			}
		}
	}
}
