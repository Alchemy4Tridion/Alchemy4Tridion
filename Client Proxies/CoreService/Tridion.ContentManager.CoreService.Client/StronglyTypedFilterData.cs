using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "StronglyTypedFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(UserWorkItemsFilterData)), KnownType(typeof(PublishedItemsFilterData)), KnownType(typeof(OrganizationalItemAncestorsFilterData)), KnownType(typeof(PublishTransactionsFilterData)), KnownType(typeof(SubjectRelatedListFilterData)), KnownType(typeof(WhereUsedFilterData)), KnownType(typeof(UsingItemsFilterData)), KnownType(typeof(UsedItemsFilterData)), KnownType(typeof(VersionsFilterData)), KnownType(typeof(DeletedReferencesFilterData)), KnownType(typeof(ItemsFilterData)), KnownType(typeof(OrganizationalItemItemsFilterData)), KnownType(typeof(RepositoryItemsFilterData)), KnownType(typeof(KeywordRelatedFilterData)), KnownType(typeof(KeywordsFilterData)), KnownType(typeof(ChildKeywordsFilterData)), KnownType(typeof(OrphanKeywordsFilterData)), KnownType(typeof(CategoryRelatedFilterData)), KnownType(typeof(ChildCategoriesFilterData)), KnownType(typeof(CategoriesFilterData)), KnownType(typeof(ClassifiedItemsFilterData)), KnownType(typeof(OrganizationalItemsFilterData)), KnownType(typeof(TaxonomiesFilterData)), KnownType(typeof(TaxonomiesOwlFilterData)), KnownType(typeof(PathToCategoryFilterData)), KnownType(typeof(GroupMembersFilterData)), KnownType(typeof(BluePrintChainFilterData)), KnownType(typeof(ContainingBundlesFilterData)), KnownType(typeof(ComponentTemplatesFilterData)), KnownType(typeof(SystemWideListFilterData)), KnownType(typeof(TrusteesFilterData)), KnownType(typeof(UsersFilterData)), KnownType(typeof(GroupsFilterData)), KnownType(typeof(RepositoriesFilterData)), KnownType(typeof(PublicationsFilterData)), KnownType(typeof(MultimediaTypesFilterData)), KnownType(typeof(TargetTypesFilterData)), KnownType(typeof(PublicationTargetsFilterData)), KnownType(typeof(WorkflowManagerFilterData)), KnownType(typeof(ApprovalStatusesFilterData)), KnownType(typeof(ProcessDefinitionsFilterData)), KnownType(typeof(ProcessDefinitionAssociationsFilterData)), KnownType(typeof(ProcessesFilterData)), KnownType(typeof(ActivityInstancesFilterData)), KnownType(typeof(BatchesFilterData)), KnownType(typeof(WorkflowTypesFilterData)), KnownType(typeof(RepositoryLocalObjectsFilterData)), KnownType(typeof(BluePrintParentsFilterData)), KnownType(typeof(BluePrintNodesFilterData)), KnownType(typeof(BluePrintFilterData)), KnownType(typeof(PublishingListFilterData))]
	public class StronglyTypedFilterData : FilterData
	{
		private bool IncludeAllowedActionsColumnsField;

		private ExtensionPropertyDictionary ExtensionPropertiesField;

		[DataMember]
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

		[DataMember(EmitDefaultValue = false, Order = 1)]
		public ExtensionPropertyDictionary ExtensionProperties
		{
			get
			{
				return this.ExtensionPropertiesField;
			}
			set
			{
				this.ExtensionPropertiesField = value;
			}
		}
	}
}
