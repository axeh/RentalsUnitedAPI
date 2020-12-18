using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutConfirmedReservation_RQ : BaseRequest
	{
		[XmlElement(IsNullable = true)]
		public int? ReservationID;

		public StayInfo StayInfo;

		public CustomerInfo CustomerInfo;

		public CostsInfo Costs;
	}
}
