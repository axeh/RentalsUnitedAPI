using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Description")]
	public class DescriptionInfo
	{
		[XmlIgnore]
		public string Text;

		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecified;

		[OptionalField]
		public int DomainID = 40;

		[XmlIgnore]
		public bool DomainIDSpecified;

		[XmlAttribute]
		public int LanguageID;

		public string Image;

		[XmlElement("Text")]
		public XmlNode[] CData
		{
			get
			{
				XmlDocument xmlDocument = new XmlDocument();
				return new XmlNode[1]
				{
					xmlDocument.CreateCDataSection(Text)
				};
			}
			set
			{
				if (value == null)
				{
					Text = null;
					return;
				}
				if (value.Length != 1)
				{
					throw new InvalidOperationException($"Invalid array length {value.Length}");
				}
				Text = value[0].Value;
			}
		}
	}
}
