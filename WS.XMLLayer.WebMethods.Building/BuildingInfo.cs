using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Building
{
	[XmlType("Building")]
	public class BuildingInfo
	{
		[XmlAttribute("BuildingID")]
		public int BuildingID;

		[XmlAttribute("BuildingName")]
		public string BuildingName;

		[XmlElement("PropertyID")]
		public List<int> PropertyIDs;
	}
}
