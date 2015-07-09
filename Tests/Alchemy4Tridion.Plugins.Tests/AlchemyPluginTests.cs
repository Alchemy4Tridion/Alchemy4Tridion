using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alchemy4Tridion.Plugins.Tests.Mocks;

namespace Alchemy4Tridion.Plugins.Tests
{
    [TestClass]
    public class AlchemyPluginTests
    {
        private IAlchemyPlugin plugin = new PluginTestsPlugin();

        [TestMethod]
        public void EditorUrl_Should_Include_Editor_Path()
        {
            plugin.EditorUrl.Should().Be("/WebUI/Editors/Alchemy/Plugins/" + plugin.Name + "/");
        }

        [TestMethod]
        public void MapEditorPath_Should_Return_Combined_Paths()
        {
            plugin.MapEditorUrl("Tests/File.txt").Should().Be("/WebUI/Editors/Alchemy/Plugins/" + plugin.Name + "/Tests/File.txt");
        }
    }
}
