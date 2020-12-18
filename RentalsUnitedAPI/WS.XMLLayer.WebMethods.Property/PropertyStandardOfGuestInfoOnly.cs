using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("PropertyStandardOfGuestOnly")]
	public class PropertyStandardOfGuestInfoOnly
	{
		public IDInfo ID;

		public int StandardGuests;
	}
}
