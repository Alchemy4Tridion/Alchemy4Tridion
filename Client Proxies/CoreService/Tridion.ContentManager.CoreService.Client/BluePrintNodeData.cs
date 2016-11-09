using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BluePrintNodeData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BluePrintNodeData : PublicationData
	{
		private RepositoryLocalObjectData ItemField;

		[DataMember(EmitDefaultValue = false)]
		public RepositoryLocalObjectData Item
		{
			get
			{
				return this.ItemField;
			}
			set
			{
				this.ItemField = value;
			}
		}
	}
}
