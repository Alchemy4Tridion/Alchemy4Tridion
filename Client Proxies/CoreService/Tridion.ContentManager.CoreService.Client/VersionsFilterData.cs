using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "VersionsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class VersionsFilterData : SubjectRelatedListFilterData
	{
		private bool? IncludeRevisorDescriptionColumnField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeRevisorDescriptionColumn
		{
			get
			{
				return this.IncludeRevisorDescriptionColumnField;
			}
			set
			{
				this.IncludeRevisorDescriptionColumnField = value;
			}
		}
	}
}
