using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RegisteredTypeData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(WorkflowTypeData))]
	public class RegisteredTypeData : SystemWideObjectData
	{
		private string NameField;

		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
			}
		}
	}
}
