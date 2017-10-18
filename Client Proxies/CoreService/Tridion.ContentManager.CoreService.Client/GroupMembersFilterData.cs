using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "GroupMembersFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class GroupMembersFilterData : SubjectRelatedListFilterData
	{
		private LinkToRepositoryData ContextRepositoryField;

		private bool? ExcludeDisabledTrusteesField;

		private bool? RecursiveField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ContextRepository
		{
			get
			{
				return this.ContextRepositoryField;
			}
			set
			{
				this.ContextRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? ExcludeDisabledTrustees
		{
			get
			{
				return this.ExcludeDisabledTrusteesField;
			}
			set
			{
				this.ExcludeDisabledTrusteesField = value;
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
	}
}
