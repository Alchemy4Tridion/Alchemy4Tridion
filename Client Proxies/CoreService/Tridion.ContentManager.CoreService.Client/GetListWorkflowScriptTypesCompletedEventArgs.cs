using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetListWorkflowScriptTypesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public WorkflowScriptType[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WorkflowScriptType[])this.results[0];
			}
		}

		public GetListWorkflowScriptTypesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
