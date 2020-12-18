using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("StatusID")]
	public class StatusIDInfo
	{
		[XmlText]
		public int StatusID;
	}
}
