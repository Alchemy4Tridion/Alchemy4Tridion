using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetExternalBinaryContentDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public BinaryContentData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (BinaryContentData)this.results[0];
			}
		}

		public GetExternalBinaryContentDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
