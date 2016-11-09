using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class RollbackCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public VersionedItemData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (VersionedItemData)this.results[0];
			}
		}

		public RollbackCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
