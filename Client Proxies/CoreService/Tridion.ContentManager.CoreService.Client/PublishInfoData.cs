using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishInfoData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishInfoData : Info
	{
		private LinkToPublicationTargetData PublicationTargetField;

		private DateTime PublishedAtField;

		private LinkToVersionedItemData RenderedWithField;

		private LinkToRepositoryData RepositoryField;

		private LinkToUserData UserField;

		private LinkToTargetTypeData TargetTypeField;

		private string TargetPurposeField;

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
		public DateTime PublishedAt
		{
			get
			{
				return this.PublishedAtField;
			}
			set
			{
				this.PublishedAtField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToVersionedItemData RenderedWith
		{
			get
			{
				return this.RenderedWithField;
			}
			set
			{
				this.RenderedWithField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData Repository
		{
			get
			{
				return this.RepositoryField;
			}
			set
			{
				this.RepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData User
		{
			get
			{
				return this.UserField;
			}
			set
			{
				this.UserField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
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
		public string TargetPurpose
		{
			get
			{
				return this.TargetPurposeField;
			}
			set
			{
				this.TargetPurposeField = value;
			}
		}
	}
}
