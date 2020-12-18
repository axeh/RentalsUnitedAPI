using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	[XmlType("LocationDistance")]
	public class LocationDistance
	{
		[XmlText]
		public string Location;

		[XmlAttribute]
		public int LocationID;

		[XmlAttribute]
		public float Distance;
	}
}
