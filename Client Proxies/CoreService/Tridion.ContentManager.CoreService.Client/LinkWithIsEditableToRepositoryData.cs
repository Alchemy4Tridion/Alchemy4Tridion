using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "LinkWithIsEditableToRepositoryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class LinkWithIsEditableToRepositoryData : LinkToRepositoryData
	{
		private bool? IsEditableField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsEditable
		{
			get
			{
				return this.IsEditableField;
			}
			set
			{
				this.IsEditableField = value;
			}
		}
	}
}
