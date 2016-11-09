using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ClassifiedItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ClassifiedItemsFilterData : SubjectRelatedListFilterData
	{
		private LinkToSchemaData[] BasedOnSchemasField;

		private ItemType[] ItemTypesField;

		private bool? ResolveDescendantKeywordsField;

		private uint? ResultLimitField;

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
		public ItemType[] ItemTypes
		{
			get
			{
				return this.ItemTypesField;
			}
			set
			{
				this.ItemTypesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? ResolveDescendantKeywords
		{
			get
			{
				return this.ResolveDescendantKeywordsField;
			}
			set
			{
				this.ResolveDescendantKeywordsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public uint? ResultLimit
		{
			get
			{
				return this.ResultLimitField;
			}
			set
			{
				this.ResultLimitField = value;
			}
		}
	}
}
