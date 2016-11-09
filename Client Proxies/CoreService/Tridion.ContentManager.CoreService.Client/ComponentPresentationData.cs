using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentPresentationData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ComponentPresentationData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToComponentData ComponentField;

		private LinkToComponentTemplateData ComponentTemplateField;

		private TargetGroupConditionData[] ConditionsField;

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
		public LinkToComponentData Component
		{
			get
			{
				return this.ComponentField;
			}
			set
			{
				this.ComponentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToComponentTemplateData ComponentTemplate
		{
			get
			{
				return this.ComponentTemplateField;
			}
			set
			{
				this.ComponentTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public TargetGroupConditionData[] Conditions
		{
			get
			{
				return this.ConditionsField;
			}
			set
			{
				this.ConditionsField = value;
			}
		}
	}
}
