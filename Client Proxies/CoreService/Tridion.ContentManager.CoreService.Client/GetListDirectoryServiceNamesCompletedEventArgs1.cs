using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetListDirectoryServiceNamesCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public string[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string[])this.results[0];
			}
		}

		public GetListDirectoryServiceNamesCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
