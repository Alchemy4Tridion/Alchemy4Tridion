using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DirectoryGroupMappingData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class DirectoryGroupMappingData : ClaimMappingData
	{
		private string DirectoryServiceNameField;

		private string SearchDNField;

		private DirectorySearchType SearchTypeField;

		[DataMember(EmitDefaultValue = false)]
		public string DirectoryServiceName
		{
			get
			{
				return this.DirectoryServiceNameField;
			}
			set
			{
				this.DirectoryServiceNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string SearchDN
		{
			get
			{
				return this.SearchDNField;
			}
			set
			{
				this.SearchDNField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DirectorySearchType SearchType
		{
			get
			{
				return this.SearchTypeField;
			}
			set
			{
				this.SearchTypeField = value;
			}
		}
	}
}
