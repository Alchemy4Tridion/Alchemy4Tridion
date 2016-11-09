using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ExpandableLinkToSchemaData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ExpandableLinkToSchemaData : LinkToSchemaData
	{
		private SchemaData ExpandedDataField;

		[DataMember(EmitDefaultValue = false)]
		public SchemaData ExpandedData
		{
			get
			{
				return this.ExpandedDataField;
			}
			set
			{
				this.ExpandedDataField = value;
			}
		}
	}
}
