using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Currency
{
	[XmlType("LocationID")]
	public class LocationIDInfo
	{
		[XmlText]
		public int LocationID;
	}
}
