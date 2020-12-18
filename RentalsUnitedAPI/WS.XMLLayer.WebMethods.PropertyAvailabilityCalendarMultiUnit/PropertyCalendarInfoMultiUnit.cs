using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	[XmlType("PropertyCalendarMultiUnit")]
	public class PropertyCalendarInfoMultiUnit
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("CalDay")]
		public List<CalDayMultiUnit> CalDays;
	}
}
