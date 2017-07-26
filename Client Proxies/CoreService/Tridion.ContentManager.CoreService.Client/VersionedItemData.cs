using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "VersionedItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ComponentData)), KnownType(typeof(PageData)), KnownType(typeof(TemplateData)), KnownType(typeof(ComponentTemplateData)), KnownType(typeof(PageTemplateData)), KnownType(typeof(TemplateBuildingBlockData)), KnownType(typeof(SchemaData)), KnownType(typeof(BundleTypeData))]
	public class VersionedItemData : RepositoryLocalObjectData
	{
		private DynamicVersionInfo DynamicVersionInfoField;

		[DataMember(EmitDefaultValue = false)]
		public DynamicVersionInfo DynamicVersionInfo
		{
			get
			{
				return this.DynamicVersionInfoField;
			}
			set
			{
				this.DynamicVersionInfoField = value;
			}
		}
	}
}
