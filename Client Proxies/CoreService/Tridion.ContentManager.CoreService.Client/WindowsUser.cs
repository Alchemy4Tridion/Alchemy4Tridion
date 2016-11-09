using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WindowsUser", Namespace = "http://www.sdltridion.com/Security")]
	public class WindowsUser : ExternalUser
	{
		private string SIDField;

		[DataMember(EmitDefaultValue = false)]
		public string SID
		{
			get
			{
				return this.SIDField;
			}
			set
			{
				this.SIDField = value;
			}
		}
	}
}
