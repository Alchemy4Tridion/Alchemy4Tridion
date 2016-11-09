using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishLocationInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishLocationInfo : LocationInfo
	{
		private string PublishLocationPathField;

		private string PublishLocationUrlField;

		private string PublishPathField;

		[DataMember(EmitDefaultValue = false)]
		public string PublishLocationPath
		{
			get
			{
				return this.PublishLocationPathField;
			}
			set
			{
				this.PublishLocationPathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublishLocationUrl
		{
			get
			{
				return this.PublishLocationUrlField;
			}
			set
			{
				this.PublishLocationUrlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublishPath
		{
			get
			{
				return this.PublishPathField;
			}
			set
			{
				this.PublishPathField = value;
			}
		}
	}
}
