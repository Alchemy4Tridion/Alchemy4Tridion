using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OperationResultDataOfRepositoryLocalObjectData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OperationResultDataOfRepositoryLocalObjectData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private RepositoryLocalObjectData ResultField;

		private ValidationWarningData[] ValidationWarningsField;

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
		public RepositoryLocalObjectData Result
		{
			get
			{
				return this.ResultField;
			}
			set
			{
				this.ResultField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ValidationWarningData[] ValidationWarnings
		{
			get
			{
				return this.ValidationWarningsField;
			}
			set
			{
				this.ValidationWarningsField = value;
			}
		}
	}
}
