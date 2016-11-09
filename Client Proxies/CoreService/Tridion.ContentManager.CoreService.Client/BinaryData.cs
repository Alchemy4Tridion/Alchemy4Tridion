using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BinaryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BinaryData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ComponentIdField;

		private string FilePathField;

		private string FilenameField;

		private string LocationIdField;

		private string MimeTypeField;

		private string PathField;

		private string RelatedComponentIdField;

		private string UrlField;

		private string VariantIdField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ComponentId
		{
			get
			{
				return this.ComponentIdField;
			}
			set
			{
				this.ComponentIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FilePath
		{
			get
			{
				return this.FilePathField;
			}
			set
			{
				this.FilePathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Filename
		{
			get
			{
				return this.FilenameField;
			}
			set
			{
				this.FilenameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string LocationId
		{
			get
			{
				return this.LocationIdField;
			}
			set
			{
				this.LocationIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string MimeType
		{
			get
			{
				return this.MimeTypeField;
			}
			set
			{
				this.MimeTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Path
		{
			get
			{
				return this.PathField;
			}
			set
			{
				this.PathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string RelatedComponentId
		{
			get
			{
				return this.RelatedComponentIdField;
			}
			set
			{
				this.RelatedComponentIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Url
		{
			get
			{
				return this.UrlField;
			}
			set
			{
				this.UrlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string VariantId
		{
			get
			{
				return this.VariantIdField;
			}
			set
			{
				this.VariantIdField = value;
			}
		}
	}
}
