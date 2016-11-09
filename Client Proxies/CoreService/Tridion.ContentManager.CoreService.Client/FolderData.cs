using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "FolderData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class FolderData : OrganizationalItemData
	{
		private bool? IsLinkedSchemaMandatoryField;

		private LinkToSchemaData LinkedSchemaField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsLinkedSchemaMandatory
		{
			get
			{
				return this.IsLinkedSchemaMandatoryField;
			}
			set
			{
				this.IsLinkedSchemaMandatoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData LinkedSchema
		{
			get
			{
				return this.LinkedSchemaField;
			}
			set
			{
				this.LinkedSchemaField = value;
			}
		}
	}
}
