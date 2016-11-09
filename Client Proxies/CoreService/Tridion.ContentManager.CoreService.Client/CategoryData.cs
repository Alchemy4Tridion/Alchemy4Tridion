using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "CategoryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class CategoryData : OrganizationalItemData
	{
		private LinkToCategoryData[] AllowedParentCategoriesField;

		private string DescriptionField;

		private bool? IsTaxonomyRootField;

		private LinkToSchemaData KeywordMetadataSchemaField;

		private bool? UseForIdentificationField;

		private bool? UseForNavigationField;

		private string XmlNameField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToCategoryData[] AllowedParentCategories
		{
			get
			{
				return this.AllowedParentCategoriesField;
			}
			set
			{
				this.AllowedParentCategoriesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsTaxonomyRoot
		{
			get
			{
				return this.IsTaxonomyRootField;
			}
			set
			{
				this.IsTaxonomyRootField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData KeywordMetadataSchema
		{
			get
			{
				return this.KeywordMetadataSchemaField;
			}
			set
			{
				this.KeywordMetadataSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? UseForIdentification
		{
			get
			{
				return this.UseForIdentificationField;
			}
			set
			{
				this.UseForIdentificationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? UseForNavigation
		{
			get
			{
				return this.UseForNavigationField;
			}
			set
			{
				this.UseForNavigationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string XmlName
		{
			get
			{
				return this.XmlNameField;
			}
			set
			{
				this.XmlNameField = value;
			}
		}
	}
}
