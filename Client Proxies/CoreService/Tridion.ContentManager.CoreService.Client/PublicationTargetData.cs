using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublicationTargetData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublicationTargetData : PublishingTargetData
	{
		private int? DefaultCodePageField;

		private TargetDestinationData[] DestinationsField;

		private LinkToApprovalStatusData MinApprovalStatusField;

		private PublishPriority? PriorityField;

		private LinkToPublicationData[] PublicationsField;

		private string TargetLanguageField;

		private LinkToTargetTypeData[] TargetTypesField;

		private bool? IsEmulatedField;

		[DataMember(EmitDefaultValue = false)]
		public int? DefaultCodePage
		{
			get
			{
				return this.DefaultCodePageField;
			}
			set
			{
				this.DefaultCodePageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public TargetDestinationData[] Destinations
		{
			get
			{
				return this.DestinationsField;
			}
			set
			{
				this.DestinationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToApprovalStatusData MinApprovalStatus
		{
			get
			{
				return this.MinApprovalStatusField;
			}
			set
			{
				this.MinApprovalStatusField = value;
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
		public LinkToPublicationData[] Publications
		{
			get
			{
				return this.PublicationsField;
			}
			set
			{
				this.PublicationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string TargetLanguage
		{
			get
			{
				return this.TargetLanguageField;
			}
			set
			{
				this.TargetLanguageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToTargetTypeData[] TargetTypes
		{
			get
			{
				return this.TargetTypesField;
			}
			set
			{
				this.TargetTypesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
		public bool? IsEmulated
		{
			get
			{
				return this.IsEmulatedField;
			}
			set
			{
				this.IsEmulatedField = value;
			}
		}
	}
}
