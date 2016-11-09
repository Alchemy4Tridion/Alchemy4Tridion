using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BluePrintInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BluePrintInfo : Info
	{
		private bool? IsLocalizedField;

		private bool? IsSharedField;

		private LinkToRepositoryData OwningRepositoryField;

		private LinkToRepositoryLocalObjectData PrimaryBluePrintParentItemField;

		[DataMember]
		public bool? IsLocalized
		{
			get
			{
				return this.IsLocalizedField;
			}
			set
			{
				this.IsLocalizedField = value;
			}
		}

		[DataMember]
		public bool? IsShared
		{
			get
			{
				return this.IsSharedField;
			}
			set
			{
				this.IsSharedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData OwningRepository
		{
			get
			{
				return this.OwningRepositoryField;
			}
			set
			{
				this.OwningRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryLocalObjectData PrimaryBluePrintParentItem
		{
			get
			{
				return this.PrimaryBluePrintParentItemField;
			}
			set
			{
				this.PrimaryBluePrintParentItemField = value;
			}
		}
	}
}
