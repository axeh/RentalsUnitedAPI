using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	public class Push_PutPrices_RS : BaseResponse
	{
		[XmlArray]
		public List<NotifInfo> Notifs;
	}
}
