using System.Web.Http;
using System.Linq;
using System.Reflection;
using System;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// The Alchemy WebAPI Controller. Alchemy controllers should inherit from this base class to automatically get
    /// picked up. An AlchemyRoutePrefixAttribute must also be added to the controller.
    /// </summary>
    /// <example>
    /// <code>
    /// [AlchemyRoutePrefix(typeof(MyPluginType), "Example")]
    /// public class ExampleController : AlchemyApiController
    /// {
    ///     [HttpGet]
    ///     [Route("hello")]
    ///     public string GetExample()
    ///     {
    ///         return "Hello Example";
    ///     }
    /// }
    /// </code>
    /// <para>
    /// The above would produce a route to /Alchemy/Plugins/YourPlugin/api/Example/hello, which when called
    /// would return a response containing the string "Hello Example".
    /// </para>
    /// </example>
    /// <remarks>
    /// An automatically created JavaScript proxy can be created for you that will allow you to call your
    /// controller's actions w/o including any other library.  To add this proxy to a resource group, add
    /// a call to the method <c>AddWebApiProxy();</c>.  After doing this, in your JavaScript files you'll
    /// be able to then make a call to <c>Alchemy.Plugins.YourPlugin.Api.Example.hello();</c>, which will
    /// return a promise.
    /// </remarks>
    public abstract class AlchemyApiController : ApiController, IAlchemyApiController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AlchemyApiController()
        {
            //var attribute = GetType().GetCustomAttributes(typeof(AlchemyRoutePrefixAttribute), true).FirstOrDefault() as AlchemyRoutePrefixAttribute;
        }
    }
   
}
