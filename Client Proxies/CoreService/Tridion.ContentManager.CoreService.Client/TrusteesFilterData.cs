using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TrusteesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(GroupsFilterData)), KnownType(typeof(UsersFilterData))]
	public class TrusteesFilterData : SystemWideListFilterData
	{
		private bool? IsPredefinedField;

		private ItemType? ItemTypeField;

		private string NameField;

		private StringSearchMode NameSearchModeField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPredefined
		{
			get
			{
				return this.IsPredefinedField;
			}
			set
			{
				this.IsPredefinedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ItemType? ItemType
		{
			get
			{
				return this.ItemTypeField;
			}
			set
			{
				this.ItemTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public StringSearchMode NameSearchMode
		{
			get
			{
				return this.NameSearchModeField;
			}
			set
			{
				this.NameSearchModeField = value;
			}
		}
	}
}
