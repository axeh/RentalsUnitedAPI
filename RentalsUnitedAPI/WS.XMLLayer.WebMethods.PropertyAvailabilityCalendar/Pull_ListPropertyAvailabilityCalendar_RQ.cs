using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	public class Pull_ListPropertyAvailabilityCalendar_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;
	}
}
