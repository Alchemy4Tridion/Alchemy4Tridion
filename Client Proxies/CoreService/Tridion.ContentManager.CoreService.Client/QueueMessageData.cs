using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "QueueMessageData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class QueueMessageData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private QueueMessageAction? ActionField;

		private DateTime? CreationDateField;

		private string CreationHostNameField;

		private int IdField;

		private LinkToIdentifiableObjectData ItemField;

		private QueueMessagePriority? PriorityField;

		private int? ProcessingConsumerIdField;

		private LinkToPublicationTargetData PublicationTargetField;

		private int? QueueIdField;

		private DateTime? ScheduleDateTimeField;

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
		public QueueMessageAction? Action
		{
			get
			{
				return this.ActionField;
			}
			set
			{
				this.ActionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? CreationDate
		{
			get
			{
				return this.CreationDateField;
			}
			set
			{
				this.CreationDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string CreationHostName
		{
			get
			{
				return this.CreationHostNameField;
			}
			set
			{
				this.CreationHostNameField = value;
			}
		}

		[DataMember(IsRequired = true, EmitDefaultValue = false)]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				this.IdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData Item
		{
			get
			{
				return this.ItemField;
			}
			set
			{
				this.ItemField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public QueueMessagePriority? Priority
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
		public int? ProcessingConsumerId
		{
			get
			{
				return this.ProcessingConsumerIdField;
			}
			set
			{
				this.ProcessingConsumerIdField = value;
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
		public int? QueueId
		{
			get
			{
				return this.QueueIdField;
			}
			set
			{
				this.QueueIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? ScheduleDateTime
		{
			get
			{
				return this.ScheduleDateTimeField;
			}
			set
			{
				this.ScheduleDateTimeField = value;
			}
		}
	}
}
