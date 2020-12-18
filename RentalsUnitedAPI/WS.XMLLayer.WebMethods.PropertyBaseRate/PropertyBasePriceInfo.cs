using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBaseRate
{
	[XmlType("PropertyBasePrice")]
	public class PropertyBasePriceInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("BasePrice")]
		public List<BasePriceInfo> BasePrice;
	}
}
