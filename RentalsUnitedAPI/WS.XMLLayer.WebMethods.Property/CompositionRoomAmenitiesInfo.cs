using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("CompositionRoomAmenities")]
	public class CompositionRoomAmenitiesInfo
	{
		[OptionalField]
		public int RoomID;

		[XmlIgnore]
		public bool RoomIDSpecified;

		[OptionalField]
		public int RoomTypeID;

		[XmlIgnore]
		public bool RoomTypeIDSpecified;

		[XmlAttribute]
		public int CompositionRoomID;

		[XmlArray]
		public List<AmenityInfo> Amenities;

		protected bool Equals(CompositionRoomAmenitiesInfo other)
		{
			return CompositionRoomID == other.CompositionRoomID;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (obj.GetType() != GetType())
			{
				return false;
			}
			return Equals((CompositionRoomAmenitiesInfo)obj);
		}

		public override int GetHashCode()
		{
			return CompositionRoomID;
		}
	}
}
