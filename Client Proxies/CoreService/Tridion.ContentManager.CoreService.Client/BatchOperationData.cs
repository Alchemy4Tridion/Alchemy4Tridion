using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BatchOperationData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BatchOperationData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string OperationField;

		private ParametersDictionary ParametersField;

		private BatchOperationStatusData[] StatusesField;

		private WeakLink[] SubjectLinksField;

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
		public string Operation
		{
			get
			{
				return this.OperationField;
			}
			set
			{
				this.OperationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ParametersDictionary Parameters
		{
			get
			{
				return this.ParametersField;
			}
			set
			{
				this.ParametersField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public BatchOperationStatusData[] Statuses
		{
			get
			{
				return this.StatusesField;
			}
			set
			{
				this.StatusesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public WeakLink[] SubjectLinks
		{
			get
			{
				return this.SubjectLinksField;
			}
			set
			{
				this.SubjectLinksField = value;
			}
		}
	}
}
