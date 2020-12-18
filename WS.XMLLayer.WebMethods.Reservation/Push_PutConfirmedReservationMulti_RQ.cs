using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutConfirmedReservationMulti_RQ : BaseRequest
	{
		public ReservationInfo Reservation;

		[XmlIgnore]
		public QuoteMode QuoteMode;

		[XmlElement]
		public int QuoteModeId
		{
			get
			{
				return (int)QuoteMode;
			}
			set
			{
				QuoteMode = (QuoteMode)value;
			}
		}
	}
}
