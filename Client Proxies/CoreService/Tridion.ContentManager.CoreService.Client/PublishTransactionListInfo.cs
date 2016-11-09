using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishTransactionListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishTransactionListInfo : ListInfo
	{
		private string ItemPathField;

		private string PublicationTargetTitleField;

		private string PublicationTitleField;

		private int? PublishActionField;

		private DateTime? ScheduleTimeField;

		[DataMember(EmitDefaultValue = false)]
		public string ItemPath
		{
			get
			{
				return this.ItemPathField;
			}
			set
			{
				this.ItemPathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublicationTargetTitle
		{
			get
			{
				return this.PublicationTargetTitleField;
			}
			set
			{
				this.PublicationTargetTitleField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublicationTitle
		{
			get
			{
				return this.PublicationTitleField;
			}
			set
			{
				this.PublicationTitleField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? PublishAction
		{
			get
			{
				return this.PublishActionField;
			}
			set
			{
				this.PublishActionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? ScheduleTime
		{
			get
			{
				return this.ScheduleTimeField;
			}
			set
			{
				this.ScheduleTimeField = value;
			}
		}
	}
}
