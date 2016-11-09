using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetListWindowsDomainUsersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WindowsUser[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WindowsUser[])this.results[0];
			}
		}

		public GetListWindowsDomainUsersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
