using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ClaimMappingData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(DirectoryGroupMappingData))]
	public class ClaimMappingData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string DescriptionField;

		private LinkToGroupData GroupField;

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
		public LinkToGroupData Group
		{
			get
			{
				return this.GroupField;
			}
			set
			{
				this.GroupField = value;
			}
		}
	}
}
