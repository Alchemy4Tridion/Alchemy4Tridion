using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ResolveInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ResolveInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ExtensionXmlField;

		private bool IncludeChildPublicationsField;

		private bool IncludeComponentLinksField;

		private bool IncludeWorkflowField;

		private ResolvePurpose? PurposeField;

		private StructureResolveOption StructureResolveOptionField;

		private bool? IncludeDynamicVersionField;

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

		[DataMember]
		public bool IncludeChildPublications
		{
			get
			{
				return this.IncludeChildPublicationsField;
			}
			set
			{
				this.IncludeChildPublicationsField = value;
			}
		}

		[DataMember]
		public bool IncludeComponentLinks
		{
			get
			{
				return this.IncludeComponentLinksField;
			}
			set
			{
				this.IncludeComponentLinksField = value;
			}
		}

		[DataMember]
		public bool IncludeWorkflow
		{
			get
			{
				return this.IncludeWorkflowField;
			}
			set
			{
				this.IncludeWorkflowField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ResolvePurpose? Purpose
		{
			get
			{
				return this.PurposeField;
			}
			set
			{
				this.PurposeField = value;
			}
		}

		[DataMember]
		public StructureResolveOption StructureResolveOption
		{
			get
			{
				return this.StructureResolveOptionField;
			}
			set
			{
				this.StructureResolveOptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public bool? IncludeDynamicVersion
		{
			get
			{
				return this.IncludeDynamicVersionField;
			}
			set
			{
				this.IncludeDynamicVersionField = value;
			}
		}
	}
}
