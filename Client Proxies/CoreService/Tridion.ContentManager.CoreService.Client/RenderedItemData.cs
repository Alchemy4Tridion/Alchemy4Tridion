using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RenderedItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RenderedItemData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private BinaryData[] BinariesField;

		private RenderedItemData[] ChildRenderedItemsField;

		private int CodePageField;

		private byte[] ContentField;

		private TimeSpan ExecutionTimeField;

		private string InstructionsField;

		private bool IsRenderedCompletelyField;

		private string MetadataField;

		private RenderInstructionData RenderInstructionField;

		private ResolvedItemData ResolvedItemField;

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
		public BinaryData[] Binaries
		{
			get
			{
				return this.BinariesField;
			}
			set
			{
				this.BinariesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RenderedItemData[] ChildRenderedItems
		{
			get
			{
				return this.ChildRenderedItemsField;
			}
			set
			{
				this.ChildRenderedItemsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int CodePage
		{
			get
			{
				return this.CodePageField;
			}
			set
			{
				this.CodePageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public byte[] Content
		{
			get
			{
				return this.ContentField;
			}
			set
			{
				this.ContentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public TimeSpan ExecutionTime
		{
			get
			{
				return this.ExecutionTimeField;
			}
			set
			{
				this.ExecutionTimeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Instructions
		{
			get
			{
				return this.InstructionsField;
			}
			set
			{
				this.InstructionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IsRenderedCompletely
		{
			get
			{
				return this.IsRenderedCompletelyField;
			}
			set
			{
				this.IsRenderedCompletelyField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Metadata
		{
			get
			{
				return this.MetadataField;
			}
			set
			{
				this.MetadataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RenderInstructionData RenderInstruction
		{
			get
			{
				return this.RenderInstructionField;
			}
			set
			{
				this.RenderInstructionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ResolvedItemData ResolvedItem
		{
			get
			{
				return this.ResolvedItemField;
			}
			set
			{
				this.ResolvedItemField = value;
			}
		}
	}
}
