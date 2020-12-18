using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	public class Pull_ListLocations_RS : BaseResponse
	{
		[XmlArray]
		public List<LocationInfo> Locations;
	}
}
