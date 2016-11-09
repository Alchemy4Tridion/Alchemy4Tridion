using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RegionDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RegionDefinitionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ComponentPresentationConstraintData[] ComponentPresentationConstraintsField;

		private ComponentPresentationData[] DefaultComponentPresentationsField;

		private RegionSchemaDictionary NestedRegionsField;

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
		public ComponentPresentationConstraintData[] ComponentPresentationConstraints
		{
			get
			{
				return this.ComponentPresentationConstraintsField;
			}
			set
			{
				this.ComponentPresentationConstraintsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ComponentPresentationData[] DefaultComponentPresentations
		{
			get
			{
				return this.DefaultComponentPresentationsField;
			}
			set
			{
				this.DefaultComponentPresentationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RegionSchemaDictionary NestedRegions
		{
			get
			{
				return this.NestedRegionsField;
			}
			set
			{
				this.NestedRegionsField = value;
			}
		}
	}
}
