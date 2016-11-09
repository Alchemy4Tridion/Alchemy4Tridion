using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WhereUsedListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WhereUsedListInfo : ListInfo
	{
		private string CommentField;

		private WhereUsedCommentToken? CommentTokenField;

		private int[] VersionsField;

		[DataMember(EmitDefaultValue = false)]
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

		[DataMember(EmitDefaultValue = false)]
		public WhereUsedCommentToken? CommentToken
		{
			get
			{
				return this.CommentTokenField;
			}
			set
			{
				this.CommentTokenField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int[] Versions
		{
			get
			{
				return this.VersionsField;
			}
			set
			{
				this.VersionsField = value;
			}
		}
	}
}
