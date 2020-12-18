using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	[XmlType("Property")]
	public class GatewayProperty
	{
		[XmlAttribute]
		public int PropertyID;

		public List<GatewayPropertyURL> PropertyURL;
	}
}
