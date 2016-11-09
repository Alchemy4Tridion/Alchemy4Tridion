using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class DownloadExternalBinaryContentCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public Stream Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (Stream)this.results[0];
			}
		}

		public DownloadExternalBinaryContentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
