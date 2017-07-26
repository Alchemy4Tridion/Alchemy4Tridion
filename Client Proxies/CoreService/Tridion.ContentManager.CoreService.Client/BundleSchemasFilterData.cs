using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BundleSchemasFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BundleSchemasFilterData : SubjectRelatedListFilterData
	{
		private bool? OnlyApplicableBundlesField;

		[DataMember(EmitDefaultValue = false)]
		public bool? OnlyApplicableBundles
		{
			get
			{
				return this.OnlyApplicableBundlesField;
			}
			set
			{
				this.OnlyApplicableBundlesField = value;
			}
		}
	}
}
