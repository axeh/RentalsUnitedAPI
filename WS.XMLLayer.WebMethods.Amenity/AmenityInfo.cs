using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Amenity
{
	[XmlType("Amenity")]
	public class AmenityInfo
	{
		[XmlText]
		public string Amenity;

		[XmlAttribute]
		public int AmenityID;

		public AmenityInfo()
		{
		}

		public AmenityInfo(int amenityID, string name)
		{
			AmenityID = amenityID;
			Amenity = name;
		}

		protected bool Equals(AmenityInfo other)
		{
			if (string.Equals(Amenity, other.Amenity))
			{
				return AmenityID == other.AmenityID;
			}
			return false;
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
			return Equals((AmenityInfo)obj);
		}

		public override int GetHashCode()
		{
			return ((Amenity?.GetHashCode() ?? 0) * 397) ^ AmenityID;
		}
	}
}
