using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class SynchronizeWithSchemaAndUpdateCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public SynchronizationResult Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SynchronizationResult)this.results[0];
			}
		}

		public SynchronizeWithSchemaAndUpdateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
