using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "MultimediaTypeData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class MultimediaTypeData : SystemWideObjectData
	{
		private FileExtensionsList FileExtensionsField;

		private string MimeTypeField;

		[DataMember(EmitDefaultValue = false)]
		public FileExtensionsList FileExtensions
		{
			get
			{
				return this.FileExtensionsField;
			}
			set
			{
				this.FileExtensionsField = value;
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
	}
}
