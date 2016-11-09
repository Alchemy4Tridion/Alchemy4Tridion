using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class FinishActivityCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ActivityInstanceData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ActivityInstanceData)this.results[0];
			}
		}

		public FinishActivityCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
