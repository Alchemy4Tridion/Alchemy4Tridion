using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PurgeOldVersionsInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PurgeOldVersionsInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToIdentifiableObjectData[] ContainersField;

		private DateTime? KeepVersionsModifiedAfterField;

		private uint? KeepVersionsWithinDaysBeforeLastCheckInField;

		private uint? MaxResolvedVersionedItemsCountField;

		private bool? RecursiveField;

		private uint? VersionsToKeepField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData[] Containers
		{
			get
			{
				return this.ContainersField;
			}
			set
			{
				this.ContainersField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? KeepVersionsModifiedAfter
		{
			get
			{
				return this.KeepVersionsModifiedAfterField;
			}
			set
			{
				this.KeepVersionsModifiedAfterField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public uint? KeepVersionsWithinDaysBeforeLastCheckIn
		{
			get
			{
				return this.KeepVersionsWithinDaysBeforeLastCheckInField;
			}
			set
			{
				this.KeepVersionsWithinDaysBeforeLastCheckInField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public uint? MaxResolvedVersionedItemsCount
		{
			get
			{
				return this.MaxResolvedVersionedItemsCountField;
			}
			set
			{
				this.MaxResolvedVersionedItemsCountField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? Recursive
		{
			get
			{
				return this.RecursiveField;
			}
			set
			{
				this.RecursiveField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public uint? VersionsToKeep
		{
			get
			{
				return this.VersionsToKeepField;
			}
			set
			{
				this.VersionsToKeepField = value;
			}
		}
	}
}
