using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, CollectionDataContract(Name = "ContainingPagesDictionary", Namespace = "http://www.sdltridion.com/ContentManager/R6", ItemName = "Item", KeyName = "ResolvedPageData", ValueName = "PublishInfoData")]
	public class ContainingPagesDictionary : Dictionary<ResolvedItemData, PublishInfoData[]>
	{
	}
}
