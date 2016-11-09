using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SingleLineTextListDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SingleLineTextListDefinitionData : ListDefinitionData
	{
		private string[] EntriesField;

		[DataMember(IsRequired = true)]
		public string[] Entries
		{
			get
			{
				return this.EntriesField;
			}
			set
			{
				this.EntriesField = value;
			}
		}
	}
}
