using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishInstructionData : PublishInstructionBaseData
	{
		private DateTime? DeployAtField;

		private uint? MaximumNumberOfRenderFailuresField;

		private RenderInstructionData RenderInstructionField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? DeployAt
		{
			get
			{
				return this.DeployAtField;
			}
			set
			{
				this.DeployAtField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public uint? MaximumNumberOfRenderFailures
		{
			get
			{
				return this.MaximumNumberOfRenderFailuresField;
			}
			set
			{
				this.MaximumNumberOfRenderFailuresField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RenderInstructionData RenderInstruction
		{
			get
			{
				return this.RenderInstructionField;
			}
			set
			{
				this.RenderInstructionField = value;
			}
		}
	}
}
