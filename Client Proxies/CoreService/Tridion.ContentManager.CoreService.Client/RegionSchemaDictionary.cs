using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, CollectionDataContract(Name = "RegionSchemaDictionary", Namespace = "http://www.sdltridion.com/ContentManager/R6", ItemName = "Region", KeyName = "Name", ValueName = "RegionSchema")]
	public class RegionSchemaDictionary : Dictionary<string, ExpandableLinkToSchemaData>
	{
	}
}
