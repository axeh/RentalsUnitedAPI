using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_CancelReservation_RQ : BaseRequest
	{
		public int ReservationID;

		[XmlIgnore]
		public CancelType? CancelTypeID;

		[XmlElement("CancelTypeID")]
		public int? CancelTypeIDInt
		{
			get
			{
				return (int?)CancelTypeID;
			}
			set
			{
				CancelTypeID = (CancelType?)value;
			}
		}
	}
}
