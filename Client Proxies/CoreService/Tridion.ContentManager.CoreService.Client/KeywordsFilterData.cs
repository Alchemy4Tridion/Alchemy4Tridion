using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "KeywordsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class KeywordsFilterData : KeywordRelatedFilterData
	{
		private bool? IsAbstractField;

		private bool? IsRootField;

		private uint? ResultLimitField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsAbstract
		{
			get
			{
				return this.IsAbstractField;
			}
			set
			{
				this.IsAbstractField = value;
			}
		}

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

		[DataMember(EmitDefaultValue = false)]
		public uint? ResultLimit
		{
			get
			{
				return this.ResultLimitField;
			}
			set
			{
				this.ResultLimitField = value;
			}
		}
	}
}
