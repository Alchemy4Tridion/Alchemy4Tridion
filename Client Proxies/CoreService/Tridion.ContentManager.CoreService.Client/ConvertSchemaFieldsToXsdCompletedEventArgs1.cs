using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class ConvertSchemaFieldsToXsdCompletedEventArgs1 : AsyncCompletedEventArgs
	{
		private object[] results;

		public XElement Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XElement)this.results[0];
			}
		}

		public ConvertSchemaFieldsToXsdCompletedEventArgs1(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
