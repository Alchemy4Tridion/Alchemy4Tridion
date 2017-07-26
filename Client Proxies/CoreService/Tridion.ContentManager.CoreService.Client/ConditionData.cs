using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ConditionData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(TargetGroupConditionData)), KnownType(typeof(CustomerCharacteristicConditionData)), KnownType(typeof(TrackingKeyConditionData))]
	public class ConditionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private bool? NegateField;

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

		[DataMember(EmitDefaultValue = false)]
		public bool? Negate
		{
			get
			{
				return this.NegateField;
			}
			set
			{
				this.NegateField = value;
			}
		}
	}
}
