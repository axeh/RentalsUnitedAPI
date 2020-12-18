using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	[XmlType("Param")]
	public class GatewayPropertyURLParams
	{
		[XmlAttribute]
		public string format;

		[XmlText]
		public string Param;
	}
}
