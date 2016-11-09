using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetCurrentUserCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public AccessTokenData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (AccessTokenData)this.results[0];
			}
		}

		public GetCurrentUserCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
