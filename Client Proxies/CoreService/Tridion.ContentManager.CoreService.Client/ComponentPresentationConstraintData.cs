using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentPresentationConstraintData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ClassificationConstraintData)), KnownType(typeof(LocationConstraintData)), KnownType(typeof(OccurenceConstraintData)), KnownType(typeof(TypeConstraintData))]
	public class ComponentPresentationConstraintData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

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
	}
}
