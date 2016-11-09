using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SearchQueryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SearchQueryData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToActivityDefinitionData ActivityDefinitionField;

		private LinkToUserData AuthorField;

		private ListBaseColumns? BaseColumnsField;

		private BasedOnSchemaData[] BasedOnSchemasField;

		private SearchBlueprintStatus? BlueprintStatusField;

		private string DescriptionField;

		private LinkToRepositoryData FromRepositoryField;

		private string FullTextQueryField;

		private bool IsDescriptionCaseSensitiveField;

		private bool? IsPublishedField;

		private bool IsTitleCaseSensitiveField;

		private ItemType[] ItemTypesField;

		private LockType? LockTypeField;

		private LinkToUserData LockUserField;

		private DateTime? ModifiedAfterField;

		private DateTime? ModifiedBeforeField;

		private LinkToProcessDefinitionData ProcessDefinitionField;

		private int? ResultLimitField;

		private LinkToIdentifiableObjectData SearchInField;

		private bool? SearchInSubtreeField;

		private string TitleField;

		private LinkToKeywordData[] UsedKeywordsField;

		private bool IncludeAllowedActionsColumnsField;

		private bool IncludeDescriptionColumnField;

		private bool IncludeLocationInfoColumnsField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToActivityDefinitionData ActivityDefinition
		{
			get
			{
				return this.ActivityDefinitionField;
			}
			set
			{
				this.ActivityDefinitionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Author
		{
			get
			{
				return this.AuthorField;
			}
			set
			{
				this.AuthorField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ListBaseColumns? BaseColumns
		{
			get
			{
				return this.BaseColumnsField;
			}
			set
			{
				this.BaseColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public BasedOnSchemaData[] BasedOnSchemas
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
		public SearchBlueprintStatus? BlueprintStatus
		{
			get
			{
				return this.BlueprintStatusField;
			}
			set
			{
				this.BlueprintStatusField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData FromRepository
		{
			get
			{
				return this.FromRepositoryField;
			}
			set
			{
				this.FromRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FullTextQuery
		{
			get
			{
				return this.FullTextQueryField;
			}
			set
			{
				this.FullTextQueryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IsDescriptionCaseSensitive
		{
			get
			{
				return this.IsDescriptionCaseSensitiveField;
			}
			set
			{
				this.IsDescriptionCaseSensitiveField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPublished
		{
			get
			{
				return this.IsPublishedField;
			}
			set
			{
				this.IsPublishedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IsTitleCaseSensitive
		{
			get
			{
				return this.IsTitleCaseSensitiveField;
			}
			set
			{
				this.IsTitleCaseSensitiveField = value;
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
		public LockType? LockType
		{
			get
			{
				return this.LockTypeField;
			}
			set
			{
				this.LockTypeField = value;
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
		public DateTime? ModifiedAfter
		{
			get
			{
				return this.ModifiedAfterField;
			}
			set
			{
				this.ModifiedAfterField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? ModifiedBefore
		{
			get
			{
				return this.ModifiedBeforeField;
			}
			set
			{
				this.ModifiedBeforeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ProcessDefinition
		{
			get
			{
				return this.ProcessDefinitionField;
			}
			set
			{
				this.ProcessDefinitionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? ResultLimit
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

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData SearchIn
		{
			get
			{
				return this.SearchInField;
			}
			set
			{
				this.SearchInField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? SearchInSubtree
		{
			get
			{
				return this.SearchInSubtreeField;
			}
			set
			{
				this.SearchInSubtreeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				this.TitleField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToKeywordData[] UsedKeywords
		{
			get
			{
				return this.UsedKeywordsField;
			}
			set
			{
				this.UsedKeywordsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 22)]
		public bool IncludeAllowedActionsColumns
		{
			get
			{
				return this.IncludeAllowedActionsColumnsField;
			}
			set
			{
				this.IncludeAllowedActionsColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 23)]
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

		[DataMember(EmitDefaultValue = false, Order = 24)]
		public bool IncludeLocationInfoColumns
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
	}
}
