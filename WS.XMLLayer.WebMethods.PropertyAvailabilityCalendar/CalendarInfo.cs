using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	[XmlType("Calendar")]
	public class CalendarInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("Availability")]
		public List<AvailabilityInfo> Availability;
	}
}
