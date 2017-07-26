using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishInstructionBaseData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(PublishInstructionData)), KnownType(typeof(UnPublishInstructionData))]
	public class PublishInstructionBaseData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ExtensionXmlField;

		private ResolveInstructionData ResolveInstructionField;

		private bool? RollbackOnFailureField;

		private DateTime? StartAtField;

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
		public string ExtensionXml
		{
			get
			{
				return this.ExtensionXmlField;
			}
			set
			{
				this.ExtensionXmlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ResolveInstructionData ResolveInstruction
		{
			get
			{
				return this.ResolveInstructionField;
			}
			set
			{
				this.ResolveInstructionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? RollbackOnFailure
		{
			get
			{
				return this.RollbackOnFailureField;
			}
			set
			{
				this.RollbackOnFailureField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? StartAt
		{
			get
			{
				return this.StartAtField;
			}
			set
			{
				this.StartAtField = value;
			}
		}
	}
}
