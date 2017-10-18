using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RepositoriesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(PublicationsFilterData))]
	public class RepositoriesFilterData : SystemWideListFilterData
	{
		private bool? IncludeWebDavUrlColumnField;

		private bool? IncludeRootOrganizationalItemsColumnsField;

		private bool? IncludeAllPublicationsForGroupManagementField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeWebDavUrlColumn
		{
			get
			{
				return this.IncludeWebDavUrlColumnField;
			}
			set
			{
				this.IncludeWebDavUrlColumnField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 1)]
		public bool? IncludeRootOrganizationalItemsColumns
		{
			get
			{
				return this.IncludeRootOrganizationalItemsColumnsField;
			}
			set
			{
				this.IncludeRootOrganizationalItemsColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 2)]
		public bool? IncludeAllPublicationsForGroupManagement
		{
			get
			{
				return this.IncludeAllPublicationsForGroupManagementField;
			}
			set
			{
				this.IncludeAllPublicationsForGroupManagementField = value;
			}
		}
	}
}
