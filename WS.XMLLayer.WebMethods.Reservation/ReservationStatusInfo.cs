using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("ReservationStatus")]
	public class ReservationStatusInfo
	{
		[XmlText]
		public string ReservationStatus;

		[XmlAttribute]
		public int ReservationStatusID;
	}
}
