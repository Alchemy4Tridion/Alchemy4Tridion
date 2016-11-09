using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TargetTypeData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TargetTypeData : PublishingTargetData
	{
		private AccessControlListData AccessControlListField;

		private LinkToBusinessProcessTypeData BusinessProcessTypeField;

		private LinkToApprovalStatusData MinimalApprovalStatusField;

		private PublishPriority? PriorityField;

		private string PurposeField;

		[DataMember(EmitDefaultValue = false)]
		public AccessControlListData AccessControlList
		{
			get
			{
				return this.AccessControlListField;
			}
			set
			{
				this.AccessControlListField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToBusinessProcessTypeData BusinessProcessType
		{
			get
			{
				return this.BusinessProcessTypeField;
			}
			set
			{
				this.BusinessProcessTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToApprovalStatusData MinimalApprovalStatus
		{
			get
			{
				return this.MinimalApprovalStatusField;
			}
			set
			{
				this.MinimalApprovalStatusField = value;
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
		public string Purpose
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
	}
}
