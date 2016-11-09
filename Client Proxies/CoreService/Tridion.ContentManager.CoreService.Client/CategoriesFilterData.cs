using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "CategoriesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class CategoriesFilterData : CategoryRelatedFilterData
	{
		private bool? IsRootField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsRoot
		{
			get
			{
				return this.IsRootField;
			}
			set
			{
				this.IsRootField = value;
			}
		}
	}
}
