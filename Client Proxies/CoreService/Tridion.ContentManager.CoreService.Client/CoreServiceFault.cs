using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class CoreServiceFault : ServiceFault
	{
		private ValidationErrorData[] ValidationErrorsField;

		private ValidationWarningData[] ValidationWarningsField;

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
