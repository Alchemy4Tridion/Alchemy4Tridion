using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class PublishCompletedEventArgs1 : AsyncCompletedEventArgs
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

		public PublishCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
