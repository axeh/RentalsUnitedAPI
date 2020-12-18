using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	public class Push_PutLongStayDiscounts_RS : BaseResponse
	{
		[XmlArray]
		public List<NotifInfo> Notifs;
	}
}
