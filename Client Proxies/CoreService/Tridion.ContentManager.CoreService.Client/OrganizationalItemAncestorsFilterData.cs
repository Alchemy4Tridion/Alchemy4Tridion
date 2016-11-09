using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OrganizationalItemAncestorsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OrganizationalItemAncestorsFilterData : SubjectRelatedListFilterData
	{
		private bool? IncludePublishLocationColumnsField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludePublishLocationColumns
		{
			get
			{
				return this.IncludePublishLocationColumnsField;
			}
			set
			{
				this.IncludePublishLocationColumnsField = value;
			}
		}
	}
}
