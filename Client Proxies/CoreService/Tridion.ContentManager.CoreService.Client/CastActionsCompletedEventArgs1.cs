using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class CastActionsCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public ActionFlags Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ActionFlags)this.results[0];
			}
		}

		public CastActionsCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
