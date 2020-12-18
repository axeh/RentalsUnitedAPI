using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	[XmlType("PropertyPrices")]
	public class PropertyPricesInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlAttribute]
		public string Currency;

		[XmlElement("PropertyPrice")]
		public List<PropertyPriceInfo> PropertyPrices;

		[XmlAttribute]
		public int Units;
	}
}
