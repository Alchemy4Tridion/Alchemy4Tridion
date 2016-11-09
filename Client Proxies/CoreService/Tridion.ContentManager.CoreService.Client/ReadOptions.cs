using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ReadOptions", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(SynchronizeOptions))]
	public class ReadOptions : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LoadFlags LoadFlagsField;

		private DynamicVersionResolvingConditions UseDynamicVersionField;

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
		public LoadFlags LoadFlags
		{
			get
			{
				return this.LoadFlagsField;
			}
			set
			{
				this.LoadFlagsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DynamicVersionResolvingConditions UseDynamicVersion
		{
			get
			{
				return this.UseDynamicVersionField;
			}
			set
			{
				this.UseDynamicVersionField = value;
			}
		}
	}
}
