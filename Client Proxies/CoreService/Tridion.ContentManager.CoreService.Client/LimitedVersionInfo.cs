using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "LimitedVersionInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(FullVersionInfo))]
	public class LimitedVersionInfo : BasicVersionInfo
	{
		private LinkToUserData CreatorField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Creator
		{
			get
			{
				return this.CreatorField;
			}
			set
			{
				this.CreatorField = value;
			}
		}
	}
}
