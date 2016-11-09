using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DateListDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class DateListDefinitionData : ListDefinitionData
	{
		private DateTime[] EntriesField;

		[DataMember(IsRequired = true)]
		public DateTime[] Entries
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
