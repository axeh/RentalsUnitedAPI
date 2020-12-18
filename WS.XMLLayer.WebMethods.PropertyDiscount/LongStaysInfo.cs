using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	public class LongStaysInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("LongStay")]
		public List<LongStayInfo> LongStays;
	}
}
