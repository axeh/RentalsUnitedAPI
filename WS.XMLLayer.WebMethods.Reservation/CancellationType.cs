using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class CancellationType
	{
		[XmlAttribute(AttributeName = "Id")]
		public int ID
		{
			get;
			set;
		}

		[XmlText]
		public string CancelType
		{
			get;
			set;
		}
	}
}
