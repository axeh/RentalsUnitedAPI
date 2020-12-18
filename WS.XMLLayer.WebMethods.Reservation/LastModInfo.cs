using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("LastMod")]
	public class LastModInfo
	{
		[XmlText]
		public string LastMod;
	}
}
