using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetPublishSourceByUrlCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public PublishSourceData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (PublishSourceData)this.results[0];
			}
		}

		public GetPublishSourceByUrlCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
