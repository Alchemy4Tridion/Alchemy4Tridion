using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OrganizationalItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OrganizationalItemsFilterData : SubjectRelatedListFilterData
	{
		private LinkToTrusteeData[] ExcludeTrusteesField;

		private bool? IncludePathColumnField;

		private bool? IncludeRelativeWebDavUrlColumnField;

		private LinkToTrusteeData[] IncludeTrusteesField;

		private ItemType[] ItemTypesField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToTrusteeData[] ExcludeTrustees
		{
			get
			{
				return this.ExcludeTrusteesField;
			}
			set
			{
				this.ExcludeTrusteesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludePathColumn
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
		public LinkToTrusteeData[] IncludeTrustees
		{
			get
			{
				return this.IncludeTrusteesField;
			}
			set
			{
				this.IncludeTrusteesField = value;
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
	}
}
