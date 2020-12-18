using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	[XmlType("CityProps")]
	public class CityPropsInfo
	{
		[XmlText]
		public int NrOfProperties;

		[XmlAttribute]
		public int LocationID;
	}
}
