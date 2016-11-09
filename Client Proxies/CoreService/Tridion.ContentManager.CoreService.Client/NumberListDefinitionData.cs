using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "NumberListDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class NumberListDefinitionData : ListDefinitionData
	{
		private double[] EntriesField;

		[DataMember(IsRequired = true)]
		public double[] Entries
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
