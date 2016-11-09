using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class TryReadCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public IdentifiableObjectData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (IdentifiableObjectData)this.results[0];
			}
		}

		public TryReadCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
