using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutConfirmedReservationMulti_RS : BaseResponse
	{
		public int ReservationID;

		[XmlIgnore]
		public List<int> ResapaIDs;
	}
}
