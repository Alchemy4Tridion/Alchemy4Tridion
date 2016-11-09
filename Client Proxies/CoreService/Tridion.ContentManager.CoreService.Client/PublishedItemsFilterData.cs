using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishedItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishedItemsFilterData : PublishingListFilterData
	{
		private LinkToPublicationData ForPublicationField;

		private bool IncludePathColumnField;

		private bool IncludeTemplatesField;

		private LinkToPublicationTargetData PublicationTargetField;

		private int? ResultLimitField;

		private LinkToTargetTypeData TargetTypeField;

		private string PurposeField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToPublicationData ForPublication
		{
			get
			{
				return this.ForPublicationField;
			}
			set
			{
				this.ForPublicationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IncludePathColumn
		{
			get
			{
				return this.IncludePathColumnField;
			}
			set
			{
				this.IncludePathColumnField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IncludeTemplates
		{
			get
			{
				return this.IncludeTemplatesField;
			}
			set
			{
				this.IncludeTemplatesField = value;
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
		public int? ResultLimit
		{
			get
			{
				return this.ResultLimitField;
			}
			set
			{
				this.ResultLimitField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
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

		[DataMember(EmitDefaultValue = false, Order = 6)]
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
