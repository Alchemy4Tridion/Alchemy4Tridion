using System.Web.Http;
using System.Linq;
using System.Reflection;
using System;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// The Alchemy WebAPI Controller. Alchemy controllers should inherit from this base class to automatically get
    /// picked up.
    /// </summary>
    public abstract class AlchemyApiController : ApiController, IAlchemyApiController
    {
        public AlchemyApiController()
        {
            //var attribute = GetType().GetCustomAttributes(typeof(AlchemyRoutePrefixAttribute), true).FirstOrDefault() as AlchemyRoutePrefixAttribute;
        }
    }
   
}
