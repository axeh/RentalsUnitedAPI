using System.Collections.Generic;
using System.Xml.Serialization;
using WS.XMLLayer.WebMethods.Amenity;

namespace WS.XMLLayer.WebMethods.CompositionRoom
{
	[XmlType("AmenitiesAvailableForRoom")]
	public class AmenitiesAvailableForRoomInfo
	{
		[XmlAttribute]
		public string CompositionRoom;

		[XmlAttribute]
		public int CompositionRoomID;

		[XmlElement("Amenity")]
		public List<AmenityInfo> Amenities;
	}
}
