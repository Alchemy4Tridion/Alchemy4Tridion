using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishingTargetData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(TargetTypeData)), KnownType(typeof(PublicationTargetData))]
	public class PublishingTargetData : SystemWideObjectData
	{
		private string DescriptionField;

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
	}
}
