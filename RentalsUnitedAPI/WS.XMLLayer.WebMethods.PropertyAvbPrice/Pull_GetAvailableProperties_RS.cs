using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetAvailableProperties_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyIDInfo> Properties;
	}
}
