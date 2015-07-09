using System.ComponentModel.Composition;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Interface that a plugin's web api controller(s) needs to implement.
    /// </summary>
    [InheritedExport(typeof(IAlchemyApiController))]
    public interface IAlchemyApiController
    {

    }
}
