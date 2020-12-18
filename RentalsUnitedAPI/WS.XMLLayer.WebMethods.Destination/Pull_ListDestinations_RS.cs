using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Destination
{
	public class Pull_ListDestinations_RS : BaseResponse
	{
		[XmlArray]
		public List<DestinationInfo> Destinations;
	}
}
