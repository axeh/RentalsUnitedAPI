using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType(TypeName = "QuoteMode")]
	public class QuoteModeObject
	{
		[XmlAttribute(AttributeName = "Id")]
		public int ID
		{
			get;
			set;
		}

		[XmlText]
		public string QuoteMode
		{
			get;
			set;
		}
	}
}
