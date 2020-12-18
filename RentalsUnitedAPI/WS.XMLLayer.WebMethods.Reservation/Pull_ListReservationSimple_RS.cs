using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationSimple_RS : BaseResponse
	{
		[XmlArray]
		public List<ReservationSimple> Reservations;
	}
}
