using Alchemy4Tridion.Plugins.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.Utilities
{
    public static class CoreServiceUtils
    {

        /// <summary>
        /// Gets the endpoint configuration name, defaulting to "netTcp_2013".
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public static string GetEndpointConfigurationName(SessionAwareCoreServiceEndPoint endPoint)
        {
            switch (endPoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp2011:
                    return "netTcp_2011";
                case SessionAwareCoreServiceEndPoint.NetTcp2012:
                    return "netTcp_2012";
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return "netTcp_201501";
                case SessionAwareCoreServiceEndPoint.NetTcp201603:
                    return "netTcp_201603";
                default:
                    return "netTcp_2013";
            }
        }
    }
}
