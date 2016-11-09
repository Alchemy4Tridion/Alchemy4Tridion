using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ValidationErrorData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ValidationErrorData : ValidationResultData
	{
		private string ErrorCodeField;

		private string ExceptionNameField;

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
		public string ExceptionName
		{
			get
			{
				return this.ExceptionNameField;
			}
			set
			{
				this.ExceptionNameField = value;
			}
		}
	}
}
