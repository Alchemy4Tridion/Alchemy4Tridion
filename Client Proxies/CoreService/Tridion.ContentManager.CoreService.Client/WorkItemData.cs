using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WorkItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WorkItemData : WorkflowObjectData
	{
		private LinkToActivityData ActivityField;

		private LinkToUserData OwnerField;

		private LinkToProcessData ProcessField;

		private LinkToIdentifiableObjectData SubjectField;

		private string CommentField;

		private LinkToRepositoryData SubjectOwningRepositoryField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToActivityData Activity
		{
			get
			{
				return this.ActivityField;
			}
			set
			{
				this.ActivityField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Owner
		{
			get
			{
				return this.OwnerField;
			}
			set
			{
				this.OwnerField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessData Process
		{
			get
			{
				return this.ProcessField;
			}
			set
			{
				this.ProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData Subject
		{
			get
			{
				return this.SubjectField;
			}
			set
			{
				this.SubjectField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string Comment
		{
			get
			{
				return this.CommentField;
			}
			set
			{
				this.CommentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public LinkToRepositoryData SubjectOwningRepository
		{
			get
			{
				return this.SubjectOwningRepositoryField;
			}
			set
			{
				this.SubjectOwningRepositoryField = value;
			}
		}
	}
}
