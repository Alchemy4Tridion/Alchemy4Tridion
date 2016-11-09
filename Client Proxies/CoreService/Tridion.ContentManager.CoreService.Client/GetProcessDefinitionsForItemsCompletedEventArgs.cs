using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetProcessDefinitionsForItemsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ProcessDefinitionAssociationDictionary Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ProcessDefinitionAssociationDictionary)this.results[0];
			}
		}

		public GetProcessDefinitionsForItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
