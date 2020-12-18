using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("JapaneseLicenceInfoRegistration")]
	public class JapaneseLicenceInfoRegistration
	{
		public string BuildingName;

		public string RoomNumber;

		public bool ShouldSerializeBuildingName => !string.IsNullOrEmpty(BuildingName);

		public bool ShouldSerializeRoomNumber => !string.IsNullOrEmpty(RoomNumber);

		internal bool IsNotEmpty()
		{
			if (!ShouldSerializeBuildingName)
			{
				return ShouldSerializeRoomNumber;
			}
			return true;
		}
	}
}
