using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutReservationToPMS_RS : BaseResponse
	{
		[XmlArray]
		[XmlArrayItem(ElementName = "ReservationID")]
		public List<string> PMSReservationIDs
		{
			get;
			set;
		}

		[XmlArray]
		public List<NotifInfo> Notifs
		{
			get;
			set;
		}
	}
}
