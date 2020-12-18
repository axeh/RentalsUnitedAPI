using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	[XmlType("PropertyCalendar")]
	public class PropertyCalendarInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("CalDay")]
		public List<CalDayInfo> CalDays;
	}
}
