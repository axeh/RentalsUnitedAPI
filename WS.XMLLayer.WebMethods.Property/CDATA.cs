using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class CDATA : IXmlSerializable
	{
		public string Text
		{
			get;
			private set;
		}

		public CDATA()
		{
		}

		public CDATA(string text)
		{
			Text = text;
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			Text = reader.ReadElementString();
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			writer.WriteCData(Text);
		}
	}
}
