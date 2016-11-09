using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessedItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessedItemData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private bool? HasRenderFailureField;

		private bool? IsRenderedField;

		private string ReasonOfRenderFailureField;

		private string RenderTimeField;

		private ResolvedItemData ResolvedItemField;

		private UndoState? UndoStateField;

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
		public bool? HasRenderFailure
		{
			get
			{
				return this.HasRenderFailureField;
			}
			set
			{
				this.HasRenderFailureField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsRendered
		{
			get
			{
				return this.IsRenderedField;
			}
			set
			{
				this.IsRenderedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ReasonOfRenderFailure
		{
			get
			{
				return this.ReasonOfRenderFailureField;
			}
			set
			{
				this.ReasonOfRenderFailureField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string RenderTime
		{
			get
			{
				return this.RenderTimeField;
			}
			set
			{
				this.RenderTimeField = value;
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

		[DataMember(EmitDefaultValue = false)]
		public UndoState? UndoState
		{
			get
			{
				return this.UndoStateField;
			}
			set
			{
				this.UndoStateField = value;
			}
		}
	}
}
