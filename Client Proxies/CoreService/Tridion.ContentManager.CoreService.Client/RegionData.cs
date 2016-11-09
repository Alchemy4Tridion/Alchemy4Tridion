using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RegionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RegionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ComponentPresentationData[] ComponentPresentationsField;

		private string MetadataField;

		private LinkToSchemaData RegionSchemaField;

		private RegionDictionary RegionsField;

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
		public ComponentPresentationData[] ComponentPresentations
		{
			get
			{
				return this.ComponentPresentationsField;
			}
			set
			{
				this.ComponentPresentationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Metadata
		{
			get
			{
				return this.MetadataField;
			}
			set
			{
				this.MetadataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData RegionSchema
		{
			get
			{
				return this.RegionSchemaField;
			}
			set
			{
				this.RegionSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RegionDictionary Regions
		{
			get
			{
				return this.RegionsField;
			}
			set
			{
				this.RegionsField = value;
			}
		}
	}
}
