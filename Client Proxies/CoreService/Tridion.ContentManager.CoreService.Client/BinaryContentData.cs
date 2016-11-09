using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BinaryContentData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BinaryContentData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private int? BinaryIdField;

		private int? FileSizeField;

		private string FilenameField;

		private bool? IsExternalField;

		private LinkToMultimediaTypeData MultimediaTypeField;

		private string UploadFromFileField;

		private string MimeTypeField;

		private string ExternalBinaryUriField;

		private long? SizeField;

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
		public int? BinaryId
		{
			get
			{
				return this.BinaryIdField;
			}
			set
			{
				this.BinaryIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? FileSize
		{
			get
			{
				return this.FileSizeField;
			}
			set
			{
				this.FileSizeField = value;
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
		public bool? IsExternal
		{
			get
			{
				return this.IsExternalField;
			}
			set
			{
				this.IsExternalField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToMultimediaTypeData MultimediaType
		{
			get
			{
				return this.MultimediaTypeField;
			}
			set
			{
				this.MultimediaTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string UploadFromFile
		{
			get
			{
				return this.UploadFromFileField;
			}
			set
			{
				this.UploadFromFileField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
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

		[DataMember(EmitDefaultValue = false, Order = 7)]
		public string ExternalBinaryUri
		{
			get
			{
				return this.ExternalBinaryUriField;
			}
			set
			{
				this.ExternalBinaryUriField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 8)]
		public long? Size
		{
			get
			{
				return this.SizeField;
			}
			set
			{
				this.SizeField = value;
			}
		}
	}
}
