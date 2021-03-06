using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "UsersFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class UsersFilterData : TrusteesFilterData
	{
		private bool? ExcludeDisabledUsersField;

		[DataMember]
		public bool? ExcludeDisabledUsers
		{
			get
			{
				return this.ExcludeDisabledUsersField;
			}
			set
			{
				this.ExcludeDisabledUsersField = value;
			}
		}
	}
}
