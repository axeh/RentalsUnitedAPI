using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("ID")]
	public class IDInfo
	{
		[XmlText]
		public int ID = -1;

		[XmlAttribute]
		public int BuildingID = -1;

		[XmlAttribute]
		public string BuildingName;
	}
}
