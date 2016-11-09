using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ContainingBundlesListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ContainingBundlesListInfo : ListInfo
	{
		private LinkToProcessDefinitionData BundleProcessField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData BundleProcess
		{
			get
			{
				return this.BundleProcessField;
			}
			set
			{
				this.BundleProcessField = value;
			}
		}
	}
}
