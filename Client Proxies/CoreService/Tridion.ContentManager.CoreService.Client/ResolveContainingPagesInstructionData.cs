using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ResolveContainingPagesInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ResolveContainingPagesInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private bool? IncludeComponentMetadataLinksField;

		private bool? IncludeDynamicVersionField;

		private bool? IncludePageMetadataLinksField;

		private bool? IncludeWorkflowField;

		private bool? ResolvePublishedPagesOnlyField;

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
		public bool? IncludeComponentMetadataLinks
		{
			get
			{
				return this.IncludeComponentMetadataLinksField;
			}
			set
			{
				this.IncludeComponentMetadataLinksField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
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

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludePageMetadataLinks
		{
			get
			{
				return this.IncludePageMetadataLinksField;
			}
			set
			{
				this.IncludePageMetadataLinksField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeWorkflow
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
		public bool? ResolvePublishedPagesOnly
		{
			get
			{
				return this.ResolvePublishedPagesOnlyField;
			}
			set
			{
				this.ResolvePublishedPagesOnlyField = value;
			}
		}
	}
}
