using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SynchronizationActionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SynchronizationActionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string FieldDescriptionField;

		private int? FieldIndexField;

		private string FieldNameField;

		private SynchronizeFlags SynchronizationActionAppliedField;

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
		public string FieldDescription
		{
			get
			{
				return this.FieldDescriptionField;
			}
			set
			{
				this.FieldDescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? FieldIndex
		{
			get
			{
				return this.FieldIndexField;
			}
			set
			{
				this.FieldIndexField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FieldName
		{
			get
			{
				return this.FieldNameField;
			}
			set
			{
				this.FieldNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public SynchronizeFlags SynchronizationActionApplied
		{
			get
			{
				return this.SynchronizationActionAppliedField;
			}
			set
			{
				this.SynchronizationActionAppliedField = value;
			}
		}
	}
}
