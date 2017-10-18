using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OrganizationalItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(FolderData)), KnownType(typeof(StructureGroupData)), KnownType(typeof(VirtualFolderData)), KnownType(typeof(ResolvedBundleData)), KnownType(typeof(CategoryData)), KnownType(typeof(BusinessProcessTypeData))]
	public class OrganizationalItemData : RepositoryLocalObjectData
	{
		private AccessControlListData AccessControlListField;

		private bool? IsPermissionsInheritanceRootField;

		private bool? IsRootOrganizationalItemField;

		[DataMember(EmitDefaultValue = false)]
		public AccessControlListData AccessControlList
		{
			get
			{
				return this.AccessControlListField;
			}
			set
			{
				this.AccessControlListField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPermissionsInheritanceRoot
		{
			get
			{
				return this.IsPermissionsInheritanceRootField;
			}
			set
			{
				this.IsPermissionsInheritanceRootField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsRootOrganizationalItem
		{
			get
			{
				return this.IsRootOrganizationalItemField;
			}
			set
			{
				this.IsRootOrganizationalItemField = value;
			}
		}
	}
}
