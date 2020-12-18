using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyMinStay
{
	public class Push_PutMinstay_RS : BaseResponse
	{
		[XmlArray]
		public List<NotifInfo> Notifs;
	}
}
