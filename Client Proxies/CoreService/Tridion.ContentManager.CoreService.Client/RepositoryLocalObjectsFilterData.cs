using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RepositoryLocalObjectsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RepositoryLocalObjectsFilterData : SystemWideListFilterData
	{
		private ComponentType[] ComponentTypesField;

		private bool? IncludeLockUserColumnField;

		private bool? IncludeRelativeWebDavUrlColumnField;

		private ItemType[] ItemTypesField;

		private LockType? LockFilterField;

		private LockType? LockResultField;

		private LinkToUserData LockUserField;

		private SchemaPurpose[] SchemaPurposesField;

		private int[] TemplateTypeIdsField;

		private LinkToSchemaData[] BasedOnSchemasField;

		private bool? IncludeLocationInfoColumnsField;

		private string[] ItemIdsField;

		private bool? UseDynamicVersionField;

		private bool IncludeDescriptionColumnField;

		private bool IncludeDynamicVersionInfoColumnsField;

		[DataMember(EmitDefaultValue = false)]
		public ComponentType[] ComponentTypes
		{
			get
			{
				return this.ComponentTypesField;
			}
			set
			{
				this.ComponentTypesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeLockUserColumn
		{
			get
			{
				return this.IncludeLockUserColumnField;
			}
			set
			{
				this.IncludeLockUserColumnField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeRelativeWebDavUrlColumn
		{
			get
			{
				return this.IncludeRelativeWebDavUrlColumnField;
			}
			set
			{
				this.IncludeRelativeWebDavUrlColumnField = value;
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
		public LockType? LockFilter
		{
			get
			{
				return this.LockFilterField;
			}
			set
			{
				this.LockFilterField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LockType? LockResult
		{
			get
			{
				return this.LockResultField;
			}
			set
			{
				this.LockResultField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData LockUser
		{
			get
			{
				return this.LockUserField;
			}
			set
			{
				this.LockUserField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public SchemaPurpose[] SchemaPurposes
		{
			get
			{
				return this.SchemaPurposesField;
			}
			set
			{
				this.SchemaPurposesField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 9)]
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

		[DataMember(EmitDefaultValue = false, Order = 10)]
		public bool? IncludeLocationInfoColumns
		{
			get
			{
				return this.IncludeLocationInfoColumnsField;
			}
			set
			{
				this.IncludeLocationInfoColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 11)]
		public string[] ItemIds
		{
			get
			{
				return this.ItemIdsField;
			}
			set
			{
				this.ItemIdsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 12)]
		public bool? UseDynamicVersion
		{
			get
			{
				return this.UseDynamicVersionField;
			}
			set
			{
				this.UseDynamicVersionField = value;
			}
		}

		[DataMember(Order = 13)]
		public bool IncludeDescriptionColumn
		{
			get
			{
				return this.IncludeDescriptionColumnField;
			}
			set
			{
				this.IncludeDescriptionColumnField = value;
			}
		}

		[DataMember(Order = 14)]
		public bool IncludeDynamicVersionInfoColumns
		{
			get
			{
				return this.IncludeDynamicVersionInfoColumnsField;
			}
			set
			{
				this.IncludeDynamicVersionInfoColumnsField = value;
			}
		}
	}
}
