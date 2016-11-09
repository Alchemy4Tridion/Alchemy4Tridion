using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentTemplatesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ComponentTemplatesFilterData : SubjectRelatedListFilterData
	{
		private bool? AllowedOnPageField;

		private LinkToRepositoryLocalObjectData[] RelatedToField;

		[DataMember(EmitDefaultValue = false)]
		public bool? AllowedOnPage
		{
			get
			{
				return this.AllowedOnPageField;
			}
			set
			{
				this.AllowedOnPageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryLocalObjectData[] RelatedTo
		{
			get
			{
				return this.RelatedToField;
			}
			set
			{
				this.RelatedToField = value;
			}
		}
	}
}
