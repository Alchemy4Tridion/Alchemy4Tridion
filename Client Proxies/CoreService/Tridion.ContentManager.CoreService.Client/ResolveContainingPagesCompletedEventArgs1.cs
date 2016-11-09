using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class ResolveContainingPagesCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public ContainingPagesDictionary Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ContainingPagesDictionary)this.results[0];
			}
		}

		public ResolveContainingPagesCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
