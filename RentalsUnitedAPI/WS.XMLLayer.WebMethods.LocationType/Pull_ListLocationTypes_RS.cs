using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LocationType
{
	public class Pull_ListLocationTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<LocationTypeInfo> LocationTypes;
	}
}
