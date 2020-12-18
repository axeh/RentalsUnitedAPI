using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	public class GatewayPushPropertyURL
	{
		[XmlAttribute]
		public int PropertyID;

		public string PageType;

		public string URL;

		public URLWithParams URLWithParams;

		public string Description;
	}
}
