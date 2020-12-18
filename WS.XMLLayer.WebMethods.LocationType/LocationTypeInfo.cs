using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LocationType
{
	[XmlType("LocationType")]
	public class LocationTypeInfo
	{
		[XmlText]
		public string LocationType;

		[XmlAttribute]
		public int LocationTypeID;
	}
}
