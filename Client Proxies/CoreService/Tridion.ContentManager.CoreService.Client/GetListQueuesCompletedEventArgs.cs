using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetListQueuesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public QueueData[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (QueueData[])this.results[0];
			}
		}

		public GetListQueuesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
