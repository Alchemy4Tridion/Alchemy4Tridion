using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "NotificationMessage", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class NotificationMessage : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ActionField;

		private string DetailsField;

		private string[] SubjectIdsField;

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
		public string Action
		{
			get
			{
				return this.ActionField;
			}
			set
			{
				this.ActionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Details
		{
			get
			{
				return this.DetailsField;
			}
			set
			{
				this.DetailsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string[] SubjectIds
		{
			get
			{
				return this.SubjectIdsField;
			}
			set
			{
				this.SubjectIdsField = value;
			}
		}
	}
}
