using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class BulkReadCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ItemReadResultDictionary Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ItemReadResultDictionary)this.results[0];
			}
		}

		public BulkReadCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
