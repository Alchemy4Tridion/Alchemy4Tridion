using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublicationsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublicationsFilterData : RepositoriesFilterData
	{
		private string PublicationTypeNameField;

		[DataMember(EmitDefaultValue = false)]
		public string PublicationTypeName
		{
			get
			{
				return this.PublicationTypeNameField;
			}
			set
			{
				this.PublicationTypeNameField = value;
			}
		}
	}
}
