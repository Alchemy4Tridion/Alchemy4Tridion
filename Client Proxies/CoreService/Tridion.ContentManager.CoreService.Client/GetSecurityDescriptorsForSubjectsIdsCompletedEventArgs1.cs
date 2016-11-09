using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs1 : AsyncCompletedEventArgs
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

		public GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
