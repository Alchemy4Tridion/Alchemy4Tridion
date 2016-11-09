using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SynchronizeOptions", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SynchronizeOptions : ReadOptions
	{
		private SynchronizeFlags SynchronizeFlagsField;

		[DataMember]
		public SynchronizeFlags SynchronizeFlags
		{
			get
			{
				return this.SynchronizeFlagsField;
			}
			set
			{
				this.SynchronizeFlagsField = value;
			}
		}
	}
}
