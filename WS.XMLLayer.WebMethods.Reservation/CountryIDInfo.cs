using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("CountryID")]
	public class CountryIDInfo
	{
		[XmlText]
		public int CountryID;
	}
}
