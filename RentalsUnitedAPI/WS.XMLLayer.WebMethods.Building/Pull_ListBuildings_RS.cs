using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Building
{
	public class Pull_ListBuildings_RS : BaseResponse
	{
		[XmlArray]
		public List<BuildingInfo> Buildings;
	}
}
