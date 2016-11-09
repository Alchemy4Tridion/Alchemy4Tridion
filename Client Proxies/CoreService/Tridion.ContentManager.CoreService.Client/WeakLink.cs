using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WeakLink", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WeakLink : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string IdRefField;

		private string TitleField;

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
		public string IdRef
		{
			get
			{
				return this.IdRefField;
			}
			set
			{
				this.IdRefField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				this.TitleField = value;
			}
		}
	}
}
