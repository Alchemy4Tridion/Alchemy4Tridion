using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class CastPredefinedQueueCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PredefinedQueue? Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PredefinedQueue?)this.results[0];
			}
		}

		public CastPredefinedQueueCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
