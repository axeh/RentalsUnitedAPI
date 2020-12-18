using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Coordinates")]
	public class CoordinatesInfo
	{
		public string Latitude;

		public string Longitude;

		public const string DefaultLatitude = "0";

		public const string DefaultLongtitude = "0";

		public CoordinatesInfo()
		{
			Latitude = "0";
			Longitude = "0";
		}
	}
}
