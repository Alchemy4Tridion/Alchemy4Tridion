using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ApplicationData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ApplicationData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ApplicationIdField;

		private byte[] DataField;

		private Link[] ManagedLinksField;

		private string TypeIdField;

		private bool? IsInheritedField;

		private string OwningRepositoryIdField;

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

		[DataMember(IsRequired = true, EmitDefaultValue = false)]
		public string ApplicationId
		{
			get
			{
				return this.ApplicationIdField;
			}
			set
			{
				this.ApplicationIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public byte[] Data
		{
			get
			{
				return this.DataField;
			}
			set
			{
				this.DataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public Link[] ManagedLinks
		{
			get
			{
				return this.ManagedLinksField;
			}
			set
			{
				this.ManagedLinksField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string TypeId
		{
			get
			{
				return this.TypeIdField;
			}
			set
			{
				this.TypeIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public bool? IsInherited
		{
			get
			{
				return this.IsInheritedField;
			}
			set
			{
				this.IsInheritedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public string OwningRepositoryId
		{
			get
			{
				return this.OwningRepositoryIdField;
			}
			set
			{
				this.OwningRepositoryIdField = value;
			}
		}
	}
}
