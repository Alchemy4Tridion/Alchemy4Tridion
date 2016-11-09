using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "StructureGroupData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class StructureGroupData : OrganizationalItemData
	{
		private LinkToPageTemplateData DefaultPageTemplateField;

		private string DirectoryField;

		private bool? IsActiveField;

		private bool? IsActiveResolvedValueField;

		private bool? IsDefaultPageTemplateInheritedField;

		private LinkToProcessDefinitionData PageProcessField;

		private LinkToProcessDefinitionData PageBundleProcessField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToPageTemplateData DefaultPageTemplate
		{
			get
			{
				return this.DefaultPageTemplateField;
			}
			set
			{
				this.DefaultPageTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Directory
		{
			get
			{
				return this.DirectoryField;
			}
			set
			{
				this.DirectoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsActive
		{
			get
			{
				return this.IsActiveField;
			}
			set
			{
				this.IsActiveField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsActiveResolvedValue
		{
			get
			{
				return this.IsActiveResolvedValueField;
			}
			set
			{
				this.IsActiveResolvedValueField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsDefaultPageTemplateInherited
		{
			get
			{
				return this.IsDefaultPageTemplateInheritedField;
			}
			set
			{
				this.IsDefaultPageTemplateInheritedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData PageProcess
		{
			get
			{
				return this.PageProcessField;
			}
			set
			{
				this.PageProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public LinkToProcessDefinitionData PageBundleProcess
		{
			get
			{
				return this.PageBundleProcessField;
			}
			set
			{
				this.PageBundleProcessField = value;
			}
		}
	}
}
