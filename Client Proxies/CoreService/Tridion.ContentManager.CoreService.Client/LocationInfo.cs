using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "LocationInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(PublishLocationInfo))]
	public class LocationInfo : Info
	{
		private LinkToRepositoryData ContextRepositoryField;

		private LinkToOrganizationalItemData OrganizationalItemField;

		private string PathField;

		private string WebDavUrlField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ContextRepository
		{
			get
			{
				return this.ContextRepositoryField;
			}
			set
			{
				this.ContextRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToOrganizationalItemData OrganizationalItem
		{
			get
			{
				return this.OrganizationalItemField;
			}
			set
			{
				this.OrganizationalItemField = value;
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
		public string WebDavUrl
		{
			get
			{
				return this.WebDavUrlField;
			}
			set
			{
				this.WebDavUrlField = value;
			}
		}
	}
}
