using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.DistanceUnit
{
	[XmlType("DistanceUnit")]
	public class DistanceUnitInfo
	{
		[XmlText]
		public string DistanceUnit;

		[XmlAttribute]
		public int DistanceUnitID;
	}
}
