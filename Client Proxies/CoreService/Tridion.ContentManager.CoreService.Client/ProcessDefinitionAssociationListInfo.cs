using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessDefinitionAssociationListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessDefinitionAssociationListInfo : ListInfo
	{
		private ItemType? ControlledItemTypeField;

		private string FileNameField;

		private bool? IsPublishedField;

		private LockType? ItemLockField;

		private string PublicationTitleField;

		private int? SubTypeField;

		[DataMember(EmitDefaultValue = false)]
		public ItemType? ControlledItemType
		{
			get
			{
				return this.ControlledItemTypeField;
			}
			set
			{
				this.ControlledItemTypeField = value;
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
		public LockType? ItemLock
		{
			get
			{
				return this.ItemLockField;
			}
			set
			{
				this.ItemLockField = value;
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
