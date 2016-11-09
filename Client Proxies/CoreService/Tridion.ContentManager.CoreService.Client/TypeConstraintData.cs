using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TypeConstraintData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TypeConstraintData : ComponentPresentationConstraintData
	{
		private LinkToComponentTemplateData BasedOnComponentTemplateField;

		private LinkToSchemaData BasedOnSchemaField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToComponentTemplateData BasedOnComponentTemplate
		{
			get
			{
				return this.BasedOnComponentTemplateField;
			}
			set
			{
				this.BasedOnComponentTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData BasedOnSchema
		{
			get
			{
				return this.BasedOnSchemaField;
			}
			set
			{
				this.BasedOnSchemaField = value;
			}
		}
	}
}
