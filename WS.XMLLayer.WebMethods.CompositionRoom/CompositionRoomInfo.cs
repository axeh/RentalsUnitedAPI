using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.CompositionRoom
{
	[XmlType("CompositionRoom")]
	public class CompositionRoomInfo
	{
		[XmlText]
		public string CompositionRoom;

		[XmlAttribute]
		public int CompositionRoomID;
	}
}
