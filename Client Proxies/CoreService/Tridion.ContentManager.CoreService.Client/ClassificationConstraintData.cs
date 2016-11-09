using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ClassificationConstraintData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ClassificationConstraintData : ComponentPresentationConstraintData
	{
		private bool AllowDescendantKeywordsField;

		private LinkToKeywordData ComponentClassifiedWithField;

		[DataMember(IsRequired = true)]
		public bool AllowDescendantKeywords
		{
			get
			{
				return this.AllowDescendantKeywordsField;
			}
			set
			{
				this.AllowDescendantKeywordsField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public LinkToKeywordData ComponentClassifiedWith
		{
			get
			{
				return this.ComponentClassifiedWithField;
			}
			set
			{
				this.ComponentClassifiedWithField = value;
			}
		}
	}
}
