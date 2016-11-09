using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishTransactionsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishTransactionsFilterData : PublishingListFilterData
	{
		private DateTime? EndDateField;

		private LinkToRepositoryData ForRepositoryField;

		private PublishPriority? PriorityField;

		private LinkToPublicationTargetData PublicationTargetField;

		private PublishTransactionState? PublishTransactionStateField;

		private LinkToUserData PublishedByField;

		private DateTime? StartDateField;

		private bool? IsCompletedField;

		private string PublisherHostField;

		private LinkToTargetTypeData TargetTypeField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? EndDate
		{
			get
			{
				return this.EndDateField;
			}
			set
			{
				this.EndDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ForRepository
		{
			get
			{
				return this.ForRepositoryField;
			}
			set
			{
				this.ForRepositoryField = value;
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
		public LinkToPublicationTargetData PublicationTarget
		{
			get
			{
				return this.PublicationTargetField;
			}
			set
			{
				this.PublicationTargetField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public PublishTransactionState? PublishTransactionState
		{
			get
			{
				return this.PublishTransactionStateField;
			}
			set
			{
				this.PublishTransactionStateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData PublishedBy
		{
			get
			{
				return this.PublishedByField;
			}
			set
			{
				this.PublishedByField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? StartDate
		{
			get
			{
				return this.StartDateField;
			}
			set
			{
				this.StartDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
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

		[DataMember(EmitDefaultValue = false, Order = 8)]
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

		[DataMember(EmitDefaultValue = false, Order = 9)]
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
	}
}
