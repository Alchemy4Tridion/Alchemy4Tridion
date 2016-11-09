using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OrganizationalItemItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OrganizationalItemItemsFilterData : ItemsFilterData
	{
		private LinkToSchemaData[] BasedOnSchemasField;

		private LinkToSchemaData NotBasedOnSchemaField;

		private bool? ShowNewItemsField;

		private int[] TemplateTypeIdsField;

		private bool FailIfNoAccessToItemsField;

		private bool IncludePathColumnField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData[] BasedOnSchemas
		{
			get
			{
				return this.BasedOnSchemasField;
			}
			set
			{
				this.BasedOnSchemasField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData NotBasedOnSchema
		{
			get
			{
				return this.NotBasedOnSchemaField;
			}
			set
			{
				this.NotBasedOnSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? ShowNewItems
		{
			get
			{
				return this.ShowNewItemsField;
			}
			set
			{
				this.ShowNewItemsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int[] TemplateTypeIds
		{
			get
			{
				return this.TemplateTypeIdsField;
			}
			set
			{
				this.TemplateTypeIdsField = value;
			}
		}

		[DataMember(Order = 4)]
		public bool FailIfNoAccessToItems
		{
			get
			{
				return this.FailIfNoAccessToItemsField;
			}
			set
			{
				this.FailIfNoAccessToItemsField = value;
			}
		}

		[DataMember(Order = 5)]
		public bool IncludePathColumn
		{
			get
			{
				return this.IncludePathColumnField;
			}
			set
			{
				this.IncludePathColumnField = value;
			}
		}
	}
}
