using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationExtended_RS : BaseResponse
	{
		[XmlArray]
		public List<ReservationExtended> Reservations
		{
			get;
			set;
		}
	}
}
