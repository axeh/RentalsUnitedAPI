using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	public class URLParam
	{
		[XmlAttribute(AttributeName = "base")]
		public string g_base;

		[XmlAttribute]
		public string format;

		[XmlAttribute]
		public string placeholder;

		[XmlText]
		public string name;
	}
}
