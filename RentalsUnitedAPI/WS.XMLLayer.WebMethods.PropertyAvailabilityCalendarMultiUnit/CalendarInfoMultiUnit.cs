using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	[XmlType("Calendar")]
	public class CalendarInfoMultiUnit
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("Availability")]
		public List<AvailabilityInfoMultiUnit> Availability;
	}
}
