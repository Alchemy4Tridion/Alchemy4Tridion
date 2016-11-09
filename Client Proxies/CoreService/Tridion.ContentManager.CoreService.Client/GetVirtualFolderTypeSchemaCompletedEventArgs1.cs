using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class GetVirtualFolderTypeSchemaCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public SchemaData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (SchemaData)this.results[0];
			}
		}

		public GetVirtualFolderTypeSchemaCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
