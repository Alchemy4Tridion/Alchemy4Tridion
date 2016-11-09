using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "UsingItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class UsingItemsFilterData : WhereUsedFilterData
	{
		private bool? ExcludeTaxonomyRelationsField;

		private bool? IncludeLocalCopiesField;

		private bool? IncludeVersionsColumnField;

		private VersionCondition IncludedVersionsField;

		[DataMember(EmitDefaultValue = false)]
		public bool? ExcludeTaxonomyRelations
		{
			get
			{
				return this.ExcludeTaxonomyRelationsField;
			}
			set
			{
				this.ExcludeTaxonomyRelationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeLocalCopies
		{
			get
			{
				return this.IncludeLocalCopiesField;
			}
			set
			{
				this.IncludeLocalCopiesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeVersionsColumn
		{
			get
			{
				return this.IncludeVersionsColumnField;
			}
			set
			{
				this.IncludeVersionsColumnField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public VersionCondition IncludedVersions
		{
			get
			{
				return this.IncludedVersionsField;
			}
			set
			{
				this.IncludedVersionsField = value;
			}
		}
	}
}
