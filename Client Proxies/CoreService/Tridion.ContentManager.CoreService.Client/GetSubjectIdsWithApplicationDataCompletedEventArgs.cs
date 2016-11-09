using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetSubjectIdsWithApplicationDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ArrayOfTcmUri Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ArrayOfTcmUri)this.results[0];
			}
		}

		public GetSubjectIdsWithApplicationDataCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
