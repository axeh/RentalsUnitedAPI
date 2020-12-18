using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Amenity")]
	public class AmenityInfo
	{
		[XmlAttribute]
		[OptionalField]
		public int RoomID;

		[XmlIgnore]
		public bool RoomIDSpecified;

		[XmlText]
		public int AmenityID;

		[XmlAttribute]
		public int Count;

		protected bool Equals(AmenityInfo other)
		{
			return AmenityID == other.AmenityID;
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
			if (obj.GetType() == GetType())
			{
				return Equals((AmenityInfo)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return AmenityID;
		}
	}
}
