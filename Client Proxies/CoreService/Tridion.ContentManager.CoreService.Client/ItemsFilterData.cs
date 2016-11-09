using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(RepositoryItemsFilterData)), KnownType(typeof(OrganizationalItemItemsFilterData))]
	public class ItemsFilterData : SubjectRelatedListFilterData
	{
		private ComponentType[] ComponentTypesField;

		private bool? IncludeRelativeWebDavUrlColumnField;

		private ItemType[] ItemTypesField;

		private LockType? LockFilterField;

		private LockType? LockResultField;

		private bool? RecursiveField;

		private SchemaPurpose[] SchemaPurposesField;

		private bool IncludeDescriptionColumnField;

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
		public bool? Recursive
		{
			get
			{
				return this.RecursiveField;
			}
			set
			{
				this.RecursiveField = value;
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

		[DataMember(Order = 7)]
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
	}
}
