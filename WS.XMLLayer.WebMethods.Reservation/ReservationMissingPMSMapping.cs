using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class ReservationMissingPMSMapping
	{
		public int RUReservationId;

		public string ExternalReservationId;

		public int RUPropertyId;

		public string PMSPropertyId;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;
	}
}
