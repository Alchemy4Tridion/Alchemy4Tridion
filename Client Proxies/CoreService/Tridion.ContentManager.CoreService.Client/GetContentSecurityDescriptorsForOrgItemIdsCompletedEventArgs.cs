using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SecurityDescriptorDataDictionary Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SecurityDescriptorDataDictionary)this.results[0];
			}
		}

		public GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
