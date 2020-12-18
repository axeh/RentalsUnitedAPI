using System;
using System.Xml;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Text")]
	public class ArriveDescriptionInfo
	{
		[XmlIgnore]
		public string Description;

		[XmlAttribute]
		public int LanguageID;

		[XmlText]
		public XmlNode[] CDataContent
		{
			get
			{
				XmlDocument xmlDocument = new XmlDocument();
				return new XmlNode[1]
				{
					xmlDocument.CreateCDataSection(Description)
				};
			}
			set
			{
				if (value != null || !string.IsNullOrEmpty(Description))
				{
					if (value.Length != 1)
					{
						throw new InvalidOperationException($"Invalid array length {value.Length}");
					}
					Description = value[0].Value;
				}
			}
		}
	}
}
