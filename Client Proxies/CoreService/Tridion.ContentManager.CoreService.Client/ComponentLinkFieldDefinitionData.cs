using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentLinkFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ComponentLinkFieldDefinitionData : ItemFieldDefinitionData
	{
		private bool AllowMultimediaLinksField;

		private LinkToSchemaData[] AllowedTargetSchemasField;

		private LinkToComponentData DefaultValueField;

		[DataMember]
		public bool AllowMultimediaLinks
		{
			get
			{
				return this.AllowMultimediaLinksField;
			}
			set
			{
				this.AllowMultimediaLinksField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public LinkToSchemaData[] AllowedTargetSchemas
		{
			get
			{
				return this.AllowedTargetSchemasField;
			}
			set
			{
				this.AllowedTargetSchemasField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToComponentData DefaultValue
		{
			get
			{
				return this.DefaultValueField;
			}
			set
			{
				this.DefaultValueField = value;
			}
		}
	}
}
