using Alchemy4Tridion.Plugins.Info;
using Alchemy4Tridion.Plugins.Tests.Mocks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Alchemy4Tridion.Plugins.Tests
{
    [TestClass]
    public class PluginSettingsTests
    {
        [TestMethod]
        public void Constructor_Should_Open_Given_Path()
        {
            IPluginSettings settings = new PluginSettings("a4t.xml");

            settings.Keys.Count().Should().Be(10);
        }

        [TestMethod]
        public void Constructor_Should_Work_If_No_Settings_Element_Exist()
        {
            IPluginSettings settings = new PluginSettings("a4t.settingless.xml");

            settings.Keys.Count().Should().Be(0);
        }

        [TestMethod]
        public void Get_Should_Return_Deserialized_Object_From_Root()
        {
            IPluginSettings settings = new PluginSettings("a4t.typed.xml");
            var person = settings.Get<StronglyTypedPerson>();

            person.WasServerKeyLoaded.Should().BeTrue();
            person.Name.Should().Be("SDLGuy");
            person.Age.Should().Be(99);
            person.IsOld.Should().BeTrue();
            person.Favorites.Count().Should().Be(3);
            person.Favorites.Last().Should().Be("Johny Walker");
        }

        [TestMethod]
        public void Get_Should_Return_Client_Only_Deserialized_Object_From_Root()
        {
            IPluginSettings settings = new PluginSettings("a4t.typed.xml");
            var person = settings.Get<StronglyTypedPerson>(true);

            person.WasServerKeyLoaded.Should().BeFalse();
            person.Name.Should().Be("SDLGuy");
            person.Age.Should().Be(99);
            person.IsOld.Should().BeTrue();
            person.Favorites.Count().Should().Be(3);
            person.Favorites.ElementAt(1).Should().Be("Anguilla");
        }

        [TestMethod]
        public void Get_Should_Return_String()
        {
            settings.Get("SomeKey").Should().Be("SomeValue");
        }

        [TestMethod]
        public void Get_Should_Return_DateTime()
        {
            var someDate = settings.Get<DateTime>("SomeDate");
            
            someDate.GetType().Should().Be(typeof(DateTime));
            someDate.Year.Should().Be(1980);
            someDate.Month.Should().Be(10);
            someDate.Day.Should().Be(6);
        }

        [TestMethod]
        public void Get_Should_Return_Null_When_Not_Found()
        {
            settings.Get("DoesNotExist").Should().BeNull();
        }

        [TestMethod]
        public void Get_Should_Return_Default_Value_When_Not_Found()
        {
            settings.Get("DoesNotExist", "SomeDefaultValue").Should().Be("SomeDefaultValue");
        }

        [TestMethod]
        public void Get_Should_Return_Default_Generic_Type_When_Not_Found()
        {
            settings.Get<bool>("DoesNotExist").Should().Be(false);
            settings.Get<bool?>("DoesNotExist").Should().Be(null);
            settings.Get<DateTime>("DoesNotExist").Should().Be(DateTime.MinValue);
        }

        [TestMethod]
        public void Get_Should_Return_Bool()
        {
            var someBool = settings.Get<bool>("SomeBool");

            someBool.GetType().Should().Be(typeof(bool));
            someBool.Should().Be(true);
        }

        [TestMethod]
        public void Get_Should_Return_Integer()
        {
            var someInt = settings.Get<int>("SomeInt");

            someInt.GetType().Should().Be(typeof(int));
            someInt.Should().Be(1234);
        }

        [TestMethod]
        public void Get_Should_Return_Double()
        {
            var someDouble = settings.Get<double>("SomeDouble");

            someDouble.GetType().Should().Be(typeof(double));
            someDouble.Should().Be(1234.56);
        }

        [TestMethod]
        public void GetSetting_Should_Return_PluginSetting()
        {
            var someSetting = settings.GetSetting("SomeKey");

            someSetting.Value.Should().Be("SomeValue");
            someSetting.Key.Should().Be("SomeKey");
            someSetting.IsEncryptedSetting.Should().BeFalse();
            someSetting.IsClientSetting.Should().BeFalse();
        }

        [TestMethod]
        public void Get_Should_Set_IsClientSetting_When_Under_Client_Element()
        {
            var someClient = settings.GetSetting("SomeClientKey");

            someClient.Value.Should().Be("SomeClientValue");
            someClient.IsClientSetting.Should().BeTrue();
        }

        [TestMethod]
        public void Get_Should_Set_IsEncryptValue_When_Under_Encrypt_Element()
        {
            var someEncrypted = settings.GetSetting("SomeEncryptedKey");

            someEncrypted.IsEncryptedSetting.Should().BeTrue();
        }

        [TestMethod]
        public void Get_Should_Treat_CData_As_String()
        {
            settings.GetSetting("SomeCData").HasNestedSettings.Should().BeFalse();

            var someValue = settings.Get("SomeCData");
            
            someValue.Should().Be("<strong>SomeCDataValue</strong>");
        }

        [TestMethod]
        public void Get_Should_Deserialize_From_Child_Elements()
        {
            var someObject = settings.Get<SomeObject>("SomeSerializedObject");

            someObject.Should().NotBeNull();
            someObject.SomeString.Should().Be("World");
            someObject.SomeBool.Should().BeTrue();
            someObject.SomeInt.Should().Be(1234);
            someObject.SomeEmbeddedObject.Should().NotBeNull();
            someObject.SomeEmbeddedObject.SomeAttribute.Should().Be(10);
            someObject.SomeEmbeddedObject.SomeEmbeddedBool.Should().BeTrue();
            someObject.SomeEmbeddedObject.SomeEmbeddedString.Should().Be("SomeString");
            someObject.DoesNotExist.Should().BeNull();
            someObject.SomeStrings.Length.Should().Be(2);
            someObject.SomeStrings.First().Should().Be("One");
            someObject.SomeInts.Length.Should().Be(3);
            someObject.SomeInts.First().Should().Be(1);
        }

        [TestMethod]
        public void GetClientType_Should_Return_ExpandoObject_When_No_ClientSettingsType_Defined()
        {
            IPluginSettings settings = new PluginSettings("a4t.typed.xml");
            IDictionary<string, object> person = (ExpandoObject)settings.GetAsClientType();

            person.ContainsKey("WasServerKeyLoaded").Should().BeFalse();
            person.ContainsKey("Name").Should().BeTrue();
            person["Name"].Should().Be("SDLGuy");
        }

        [TestMethod]
        public void GetClientType_Should_Return_Deserialized_Type_Defined_In_Service()
        {
            IAlchemyPlugin plugin = new PluginTestsPlugin();
            plugin.Services.SettingsDeserialization = new SettingsDeserializationService();
            plugin.Services.SettingsDeserialization.ClientSettingsType = typeof(StronglyTypedPerson);
            IPluginSettings settings = new PluginSettings("a4t.typed.xml", plugin);

            var person = (StronglyTypedPerson)settings.GetAsClientType();

            person.WasServerKeyLoaded.Should().BeFalse();
            person.Name.Should().Be("SDLGuy");
            person.Age.Should().Be(99);
            person.IsOld.Should().BeTrue();
            person.Favorites.Count().Should().Be(3);
            person.Favorites.Last().Should().Be("Johny Walker");
        }

        [TestMethod]
        public void GetNestedSettings_Should_Return_Correct_Nested_Values()
        {
            var nested = settings.GetNestedSettings("SomeSerializedObject");

            nested.Should().NotBeNull();
            nested.Get("SomeString").Should().Be("World");
        }

        [TestMethod]
        public void GetList_Should_Return_List_Of_Strings()
        {
            var someList = settings.GetList("SomeList");

            someList.Should().NotBeNull();
            someList.Count().Should().Be(6);
            someList.First().Should().Be("aye");
            someList.ElementAt(2).Should().Be("see");
        }

        [TestMethod]
        public void GetList_Should_Return_Null_When_Not_Found()
        {
            settings.GetList("NotFound").Should().BeNull();
        }

        [TestMethod]
        public void Keys_Should_Not_Includ_Client_Or_Encrypt_Or_Add()
        {
            this.settings.Keys.Should().NotContain("add");
            this.settings.Keys.Should().NotContain("client");
            this.settings.Keys.Should().NotContain("encrypt");
        }

        [TestMethod]
        public void Keys_Should_Return_List()
        {
            this.settings.Keys.Count().Should().Be(10);
        }

        public IPluginSettings settings;

        [TestInitialize]
        public void TestInit()
        {
            var doc = XDocument.Load("a4t.xml");
            this.settings = new PluginSettings(doc);
        }
    }

    public class SomeObject
    {
        public string SomeString
        {
            get;
            set;
        }

        /// <summary>
        /// By using XmlArrayItemAttribute, we can specify the name of the array item elements. In this example,
        /// they'll be elements with name of "Item". W/o the attribute, they would need to be the name of "int".
        /// </summary>
        [XmlArrayItem(ElementName = "Item", Type = typeof(int))]
        public int[] SomeInts
        {
            get;
            set;
        }

        /// <summary>
        /// If not using the XmlArrayItemAttribute, the nested element names must be of the type.  Here they
        /// must be elements with name of "string".
        /// </summary>
        public string[] SomeStrings
        {
            get;
            set;
        }

        public bool SomeBool
        {
            get;
            set;
        }

        public int SomeInt
        {
            get;
            set;
        }

        public EmbeddedObject SomeEmbeddedObject
        {
            get;
            set;
        }

        public EmbeddedObject DoesNotExist
        {
            get;
            set;
        }
    }

    public class EmbeddedObject
    {
        /// <summary>
        /// We are getting this property from the element's 'someAttribute' attribute.
        /// </summary>
        [XmlAttribute("someAttribute")]
        public int SomeAttribute
        {
            get;
            set;
        }

        public bool SomeEmbeddedBool
        {
            get;
            set;
        }

        public string SomeEmbeddedString
        {
            get;
            set;
        }
    }

    public class StronglyTypedPerson : IStronglyTypedClientSettings
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsOld { get; set; }

        [XmlArrayItem("Fav")]
        public List<string> Favorites { get; set; }

        public bool WasServerKeyLoaded { get; set; }
    }
}
