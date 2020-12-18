using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	public class Push_PutAvb_RS : BaseResponse
	{
		[XmlArray]
		public List<NotifInfo> Notifs;
	}
}
