using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.CompositionRoom
{
	public class Pull_ListCompositionRooms_RS : BaseResponse
	{
		[XmlArray]
		public List<CompositionRoomInfo> CompositionRooms;
	}
}
