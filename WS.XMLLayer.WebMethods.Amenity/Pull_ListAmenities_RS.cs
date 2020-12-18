using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Amenity
{
	public class Pull_ListAmenities_RS : BaseResponse
	{
		[XmlArray]
		public List<AmenityInfo> Amenities;
	}
}
