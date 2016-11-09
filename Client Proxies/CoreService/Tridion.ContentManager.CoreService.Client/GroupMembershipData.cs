using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "GroupMembershipData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class GroupMembershipData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToGroupData GroupField;

		private LinkWithIsEditableToRepositoryData[] ScopeField;

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

		[DataMember]
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

		[DataMember]
		public LinkWithIsEditableToRepositoryData[] Scope
		{
			get
			{
				return this.ScopeField;
			}
			set
			{
				this.ScopeField = value;
			}
		}
	}
}
