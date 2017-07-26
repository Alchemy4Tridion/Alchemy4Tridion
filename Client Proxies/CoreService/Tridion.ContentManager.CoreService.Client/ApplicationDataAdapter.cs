using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public class ApplicationDataAdapter
	{
		private readonly ApplicationData _applicationData;

		private object _typedApplicationData;

		private readonly bool _isTyped;

		public ApplicationData ApplicationData
		{
			get
			{
				if (this._isTyped)
				{
					this.Serialize();
				}
				return this._applicationData;
			}
		}

		public ApplicationDataAdapter(string applicationId, object typedApplicationData)
		{
			ApplicationDataAdapter.AssertNotNull(applicationId, "applicationId");
			this._applicationData = new ApplicationData
			{
				ApplicationId = applicationId
			};
			this._typedApplicationData = typedApplicationData;
			this._isTyped = true;
		}

		public ApplicationDataAdapter(ApplicationData applicationDataObject)
		{
			ApplicationDataAdapter.AssertNotNull(applicationDataObject, "applicationDataObject");
			this._applicationData = applicationDataObject;
			this._typedApplicationData = null;
			this._isTyped = false;
		}

		public T GetAs<T>()
		{
			if (!this._isTyped)
			{
				this.Deserialize(typeof(T));
			}
			return (T)((object)this._typedApplicationData);
		}

		private void Serialize()
		{
			if (this._typedApplicationData == null)
			{
				this._applicationData.Data = new byte[0];
				this._applicationData.TypeId = string.Empty;
				return;
			}
			if (ApplicationDataAdapter.HasAttribute(this._typedApplicationData, typeof(DataContractAttribute)))
			{
				DataContractSerializer dataContractSerializer = new DataContractSerializer(this._typedApplicationData.GetType());
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (XmlDictionaryWriter xmlDictionaryWriter = XmlDictionaryWriter.CreateBinaryWriter(memoryStream))
					{
						dataContractSerializer.WriteObject(xmlDictionaryWriter, this._typedApplicationData);
					}
					this._applicationData.Data = memoryStream.ToArray();
				}
				this._applicationData.TypeId = ApplicationDataAdapter.BuildTypeIdForDataContract(this._typedApplicationData);
				return;
			}
			if (ApplicationDataAdapter.HasAttribute(this._typedApplicationData, typeof(SerializableAttribute)))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					((IFormatter)new BinaryFormatter()).Serialize(memoryStream2, this._typedApplicationData);
					this._applicationData.Data = memoryStream2.ToArray();
				}
				this._applicationData.TypeId = ApplicationDataAdapter.BuildTypeIdForSerializable(this._typedApplicationData);
				return;
			}
			if (this._typedApplicationData is XmlElement)
			{
				XmlElement xmlElement = (XmlElement)this._typedApplicationData;
				this._applicationData.Data = Encoding.UTF8.GetBytes(xmlElement.OuterXml);
				this._applicationData.TypeId = ApplicationDataAdapter.BuildTypeIdForXmlElement(xmlElement);
				return;
			}
			throw new NotSupportedException(string.Format("The conversion of '{0}' type is not supported. The type must be one of: WCF data contract, XmlElement, serializable", this._typedApplicationData.GetType().Name));
		}

		private void Deserialize(Type expectedType)
		{
			if (this._applicationData.Data == null || this._applicationData.Data.Length == 0)
			{
				this._typedApplicationData = null;
				return;
			}
			if (this._applicationData.TypeId.StartsWith("DataContract:"))
			{
				DataContractSerializer dataContractSerializer = new DataContractSerializer(expectedType);
				using (MemoryStream memoryStream = new MemoryStream(this._applicationData.Data))
				{
					using (XmlDictionaryReader xmlDictionaryReader = XmlDictionaryReader.CreateBinaryReader(memoryStream, XmlDictionaryReaderQuotas.Max))
					{
						this._typedApplicationData = dataContractSerializer.ReadObject(xmlDictionaryReader);
						return;
					}
				}
			}
			if (this._applicationData.TypeId.StartsWith("Serializable:"))
			{
				using (MemoryStream memoryStream2 = new MemoryStream(this._applicationData.Data))
				{
					IFormatter formatter = new BinaryFormatter();
					this._typedApplicationData = formatter.Deserialize(memoryStream2);
					return;
				}
			}
			if (this._applicationData.TypeId.StartsWith("XmlElement:"))
			{
				string @string = Encoding.UTF8.GetString(this._applicationData.Data);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(@string);
				this._typedApplicationData = xmlDocument.DocumentElement;
				return;
			}
			throw new NotSupportedException("The ApplicationData object can not be converted due to unrecognized type id: " + this._applicationData.TypeId);
		}

		private static string BuildTypeIdForDataContract(object appDataObject)
		{
			Type type = appDataObject.GetType();
			DataContractAttribute dataContractAttribute = (DataContractAttribute)type.GetCustomAttributes(typeof(DataContractAttribute), false)[0];
			string arg = string.IsNullOrEmpty(dataContractAttribute.Name) ? type.Name : dataContractAttribute.Name;
			string arg2 = string.IsNullOrEmpty(dataContractAttribute.Namespace) ? type.Namespace : dataContractAttribute.Namespace;
			return string.Format("DataContract:{0}, {1}, {2}", arg, arg2, type.Assembly.GetName().Version);
		}

		private static string BuildTypeIdForSerializable(object appDataObject)
		{
			return string.Format("Serializable:{0}", appDataObject.GetType().AssemblyQualifiedName);
		}

		private static string BuildTypeIdForXmlElement(XmlElement appDataObject)
		{
			string arg = string.IsNullOrEmpty(appDataObject.NamespaceURI) ? appDataObject.GetType().Namespace : appDataObject.NamespaceURI;
			return string.Format("XmlElement:{0}, {1}", appDataObject.LocalName, arg);
		}

		private static bool HasAttribute(object objectToCheck, Type attributeType)
		{
			return objectToCheck.GetType().GetCustomAttributes(attributeType, false).Length != 0;
		}

		private static void AssertNotNull(object value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
		}
	}
}
