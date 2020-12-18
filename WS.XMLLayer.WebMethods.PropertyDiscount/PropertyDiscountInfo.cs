using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	public class PropertyDiscountInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlArray]
		public List<LongStayInfo> LongStays;

		[XmlArray]
		public List<LastMinuteInfo> LastMinutes;
	}
}
