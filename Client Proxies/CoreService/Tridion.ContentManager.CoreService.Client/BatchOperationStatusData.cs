using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BatchOperationStatusData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BatchOperationStatusData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ErrorCodeField;

		private int IdField;

		private string InformationField;

		private BatchOperationState StateField;

		private string SubjectIdField;

		private ValidationErrorData[] ValidationErrorsField;

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
		public string ErrorCode
		{
			get
			{
				return this.ErrorCodeField;
			}
			set
			{
				this.ErrorCodeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				this.IdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Information
		{
			get
			{
				return this.InformationField;
			}
			set
			{
				this.InformationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public BatchOperationState State
		{
			get
			{
				return this.StateField;
			}
			set
			{
				this.StateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string SubjectId
		{
			get
			{
				return this.SubjectIdField;
			}
			set
			{
				this.SubjectIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ValidationErrorData[] ValidationErrors
		{
			get
			{
				return this.ValidationErrorsField;
			}
			set
			{
				this.ValidationErrorsField = value;
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
