using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BusinessProcessTypeData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BusinessProcessTypeData : OrganizationalItemData
	{
		private LinkToSchemaData[] BundleSchemasField;

		private string CdTopologyTypeIdField;

		private string DescriptionField;

		private TargetTypeData[] TargetTypesField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData[] BundleSchemas
		{
			get
			{
				return this.BundleSchemasField;
			}
			set
			{
				this.BundleSchemasField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string CdTopologyTypeId
		{
			get
			{
				return this.CdTopologyTypeIdField;
			}
			set
			{
				this.CdTopologyTypeIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public TargetTypeData[] TargetTypes
		{
			get
			{
				return this.TargetTypesField;
			}
			set
			{
				this.TargetTypesField = value;
			}
		}
	}
}
