using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BluePrintChainFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BluePrintChainFilterData : SubjectRelatedListFilterData
	{
		private BluePrintChainDirection DirectionField;

		private bool? IncludeWebDavUrlColumnField;

		[DataMember(EmitDefaultValue = false)]
		public BluePrintChainDirection Direction
		{
			get
			{
				return this.DirectionField;
			}
			set
			{
				this.DirectionField = value;
			}
		}

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
	}
}
