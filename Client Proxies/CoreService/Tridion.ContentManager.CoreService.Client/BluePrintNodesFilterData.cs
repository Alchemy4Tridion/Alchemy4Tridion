using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BluePrintNodesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(BluePrintFilterData))]
	public class BluePrintNodesFilterData : SystemWideListFilterData
	{
		private LinkToRepositoryLocalObjectData ForItemField;

		private LinkToRepositoryData ForRepositoryField;

		private bool? IncludeWebDavUrlColumnField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryLocalObjectData ForItem
		{
			get
			{
				return this.ForItemField;
			}
			set
			{
				this.ForItemField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ForRepository
		{
			get
			{
				return this.ForRepositoryField;
			}
			set
			{
				this.ForRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeWebDavUrlColumn
		{
			get
			{
				return this.IncludeWebDavUrlColumnField;
			}
			set
			{
				this.IncludeWebDavUrlColumnField = value;
			}
		}
	}
}
