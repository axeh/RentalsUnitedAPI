using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationsMissingPMSMapping_RS : BaseResponse
	{
		[XmlArray]
		public ReservationMissingPMSMapping[] Reservations;
	}
}
