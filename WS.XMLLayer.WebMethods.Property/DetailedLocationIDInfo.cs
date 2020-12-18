using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("DetailedLocationID")]
	public class DetailedLocationIDInfo
	{
		[XmlText]
		public int DetailedLocationID;

		[XmlAttribute]
		public int TypeID;
	}
}
