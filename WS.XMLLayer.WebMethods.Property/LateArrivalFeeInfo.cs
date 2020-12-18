using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("LateArrivalFee")]
	public class LateArrivalFeeInfo
	{
		[XmlAttribute]
		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecfied;

		[XmlText]
		public decimal Fee;

		[XmlAttribute]
		public string From;

		[XmlAttribute]
		public string To;
	}
}
