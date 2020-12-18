using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("CompositionRoomID")]
	public class CompositionRoomIDInfo
	{
		[XmlAttribute]
		[OptionalField]
		public int RoomID;

		[XmlIgnore]
		public bool RoomIDSpecified;

		[XmlText]
		public int CompositionRoomID;

		[XmlAttribute]
		public int Count;

		protected bool Equals(CompositionRoomIDInfo other)
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
			if (obj.GetType() == GetType())
			{
				return Equals((CompositionRoomIDInfo)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return CompositionRoomID;
		}
	}
}
