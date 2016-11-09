using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WorkItemListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WorkItemListInfo : ListInfo
	{
		private DateTime? ActivityCreationDateField;

		private string ActivityDefinitionTitleField;

		private DateTime? ActivityStartDateField;

		private ActivityState? ActivityStateField;

		private ActivityType? ActivityTypeField;

		private string FileNameField;

		private bool? IsPublishedField;

		private int? SubTypeField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? ActivityCreationDate
		{
			get
			{
				return this.ActivityCreationDateField;
			}
			set
			{
				this.ActivityCreationDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ActivityDefinitionTitle
		{
			get
			{
				return this.ActivityDefinitionTitleField;
			}
			set
			{
				this.ActivityDefinitionTitleField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? ActivityStartDate
		{
			get
			{
				return this.ActivityStartDateField;
			}
			set
			{
				this.ActivityStartDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ActivityState? ActivityState
		{
			get
			{
				return this.ActivityStateField;
			}
			set
			{
				this.ActivityStateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ActivityType? ActivityType
		{
			get
			{
				return this.ActivityTypeField;
			}
			set
			{
				this.ActivityTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FileName
		{
			get
			{
				return this.FileNameField;
			}
			set
			{
				this.FileNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPublished
		{
			get
			{
				return this.IsPublishedField;
			}
			set
			{
				this.IsPublishedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? SubType
		{
			get
			{
				return this.SubTypeField;
			}
			set
			{
				this.SubTypeField = value;
			}
		}
	}
}
