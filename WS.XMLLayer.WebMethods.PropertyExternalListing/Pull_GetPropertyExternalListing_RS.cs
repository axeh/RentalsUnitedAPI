using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalListing
{
	public class Pull_GetPropertyExternalListing_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyGetInfo> Properties;

		[XmlArray]
		public List<NotifInfo> Notifs;
	}
}
