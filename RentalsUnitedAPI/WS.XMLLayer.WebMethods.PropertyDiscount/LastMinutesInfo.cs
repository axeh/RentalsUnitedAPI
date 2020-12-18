using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	public class LastMinutesInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("LastMinute")]
		public List<LastMinuteInfo> LastMinutes;
	}
}
