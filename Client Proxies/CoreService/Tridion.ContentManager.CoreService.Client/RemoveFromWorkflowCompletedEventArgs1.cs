using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class RemoveFromWorkflowCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public WorkItemData[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (WorkItemData[])this.results[0];
			}
		}

		public RemoveFromWorkflowCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
