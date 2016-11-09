using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishTransactionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishTransactionData : SystemWideObjectData
	{
		private LinkToUserData CreatorField;

		private DeployerAction? DeployerActionField;

		private bool? HasRenderFailuresField;

		private string InformationField;

		private PublishInstructionBaseData InstructionField;

		private LinkToIdentifiableObjectData[] ItemsField;

		private PublishPriority? PriorityField;

		private PublishContextData[] PublishContextsField;

		private PublishTransactionState? StateField;

		private DateTime? StateChangeDateTimeField;

		private bool? IsCompletedField;

		private string PublisherHostField;

		private LinkToTargetTypeData TargetTypeField;

		private TimeSpan? RenderingTimeField;

		private TimeSpan? ResolvingTimeField;

		private TimeSpan? TotalExecutionTimeField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Creator
		{
			get
			{
				return this.CreatorField;
			}
			set
			{
				this.CreatorField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DeployerAction? DeployerAction
		{
			get
			{
				return this.DeployerActionField;
			}
			set
			{
				this.DeployerActionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? HasRenderFailures
		{
			get
			{
				return this.HasRenderFailuresField;
			}
			set
			{
				this.HasRenderFailuresField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Information
		{
			get
			{
				return this.InformationField;
			}
			set
			{
				this.InformationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public PublishInstructionBaseData Instruction
		{
			get
			{
				return this.InstructionField;
			}
			set
			{
				this.InstructionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData[] Items
		{
			get
			{
				return this.ItemsField;
			}
			set
			{
				this.ItemsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public PublishPriority? Priority
		{
			get
			{
				return this.PriorityField;
			}
			set
			{
				this.PriorityField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public PublishContextData[] PublishContexts
		{
			get
			{
				return this.PublishContextsField;
			}
			set
			{
				this.PublishContextsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public PublishTransactionState? State
		{
			get
			{
				return this.StateField;
			}
			set
			{
				this.StateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? StateChangeDateTime
		{
			get
			{
				return this.StateChangeDateTimeField;
			}
			set
			{
				this.StateChangeDateTimeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 10)]
		public bool? IsCompleted
		{
			get
			{
				return this.IsCompletedField;
			}
			set
			{
				this.IsCompletedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 11)]
		public string PublisherHost
		{
			get
			{
				return this.PublisherHostField;
			}
			set
			{
				this.PublisherHostField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 12)]
		public LinkToTargetTypeData TargetType
		{
			get
			{
				return this.TargetTypeField;
			}
			set
			{
				this.TargetTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 13)]
		public TimeSpan? RenderingTime
		{
			get
			{
				return this.RenderingTimeField;
			}
			set
			{
				this.RenderingTimeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 14)]
		public TimeSpan? ResolvingTime
		{
			get
			{
				return this.ResolvingTimeField;
			}
			set
			{
				this.ResolvingTimeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 15)]
		public TimeSpan? TotalExecutionTime
		{
			get
			{
				return this.TotalExecutionTimeField;
			}
			set
			{
				this.TotalExecutionTimeField = value;
			}
		}
	}
}
