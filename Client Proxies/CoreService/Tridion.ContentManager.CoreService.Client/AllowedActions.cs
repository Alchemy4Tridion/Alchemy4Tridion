using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "AllowedActions", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class AllowedActions : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private int AllowField;

		private int DenyField;

		private int? ManagedField;

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
		public int Allow
		{
			get
			{
				return this.AllowField;
			}
			set
			{
				this.AllowField = value;
			}
		}

		[DataMember]
		public int Deny
		{
			get
			{
				return this.DenyField;
			}
			set
			{
				this.DenyField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Managed
		{
			get
			{
				return this.ManagedField;
			}
			set
			{
				this.ManagedField = value;
			}
		}
	}
}
