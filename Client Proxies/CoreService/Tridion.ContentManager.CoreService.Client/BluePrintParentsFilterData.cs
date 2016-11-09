using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BluePrintParentsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BluePrintParentsFilterData : SystemWideListFilterData
	{
		private LinkToRepositoryData[] CurrentParentsField;

		private LinkToRepositoryData ForRepositoryField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData[] CurrentParents
		{
			get
			{
				return this.CurrentParentsField;
			}
			set
			{
				this.CurrentParentsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ForRepository
		{
			get
			{
				return this.ForRepositoryField;
			}
			set
			{
				this.ForRepositoryField = value;
			}
		}
	}
}
