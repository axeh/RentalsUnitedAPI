using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Destination
{
	[XmlType("Destination")]
	public class DestinationInfo
	{
		[XmlText]
		public string Destination;

		[XmlAttribute]
		public int DestinationID;
	}
}
