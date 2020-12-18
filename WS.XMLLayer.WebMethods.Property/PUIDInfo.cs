using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("PUID")]
	public class PUIDInfo
	{
		[XmlText]
		public string PUID;

		[XmlAttribute]
		public int BuildingID = -1;
	}
}
