using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("EarlyDepartureFee")]
	public class EarlyDepartureFeeInfo
	{
		[XmlAttribute]
		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecified;

		[XmlText]
		public decimal Fee;

		[XmlAttribute]
		public string From;

		[XmlAttribute]
		public string To;
	}
}
