using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_GetOwnReservations_RS : BaseResponse
	{
		[XmlArray]
		public List<ReservationInfo> Reservations;
	}
}
