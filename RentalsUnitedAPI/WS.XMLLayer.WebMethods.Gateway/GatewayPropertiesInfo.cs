using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	[XmlType("Property")]
	public class GatewayPropertiesInfo
	{
		[XmlText]
		public int PropertyID;
	}
}
