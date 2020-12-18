using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	public class AvailabilityInfo
	{
		[XmlAttribute(DataType = "date")]
		public DateTime DateFrom;

		[XmlAttribute(DataType = "date")]
		public DateTime DateTo;

		[XmlText]
		public bool Availability;
	}
}
