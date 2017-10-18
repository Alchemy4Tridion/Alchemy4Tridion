using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ExpandableLinkToTridionActivityDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ExpandableLinkToTridionActivityDefinitionData : LinkToTridionActivityDefinitionData
	{
		private TridionActivityDefinitionData ExpandedDataField;

		[DataMember(EmitDefaultValue = false)]
		public TridionActivityDefinitionData ExpandedData
		{
			get
			{
				return this.ExpandedDataField;
			}
			set
			{
				this.ExpandedDataField = value;
			}
		}
	}
}
