using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ContainingBundlesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ContainingBundlesFilterData : SubjectRelatedListFilterData
	{
		private bool IncludeBundleTypeColumnsField;

		private bool IncludeDescriptionColumnField;

		private bool OnlySpecifiedBluePrintVariantField;

		private bool SuppressLocalCopiesField;

		[DataMember(EmitDefaultValue = false)]
		public bool IncludeBundleTypeColumns
		{
			get
			{
				return this.IncludeBundleTypeColumnsField;
			}
			set
			{
				this.IncludeBundleTypeColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IncludeDescriptionColumn
		{
			get
			{
				return this.IncludeDescriptionColumnField;
			}
			set
			{
				this.IncludeDescriptionColumnField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool OnlySpecifiedBluePrintVariant
		{
			get
			{
				return this.OnlySpecifiedBluePrintVariantField;
			}
			set
			{
				this.OnlySpecifiedBluePrintVariantField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool SuppressLocalCopies
		{
			get
			{
				return this.SuppressLocalCopiesField;
			}
			set
			{
				this.SuppressLocalCopiesField = value;
			}
		}
	}
}
