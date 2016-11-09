using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class PublishCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishTransactionData[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishTransactionData[])this.results[0];
			}
		}

		public PublishCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
