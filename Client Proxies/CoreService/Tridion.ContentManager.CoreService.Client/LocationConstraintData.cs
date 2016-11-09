using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "LocationConstraintData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class LocationConstraintData : ComponentPresentationConstraintData
	{
		private bool AllowSubFoldersField;

		private LinkToFolderData ComponentInFolderField;

		[DataMember(IsRequired = true)]
		public bool AllowSubFolders
		{
			get
			{
				return this.AllowSubFoldersField;
			}
			set
			{
				this.AllowSubFoldersField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public LinkToFolderData ComponentInFolder
		{
			get
			{
				return this.ComponentInFolderField;
			}
			set
			{
				this.ComponentInFolderField = value;
			}
		}
	}
}
