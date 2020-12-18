using ProtoBuf;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	[ProtoContract]
	[XmlType("LocationWithCurrency")]
	public class LocationWithCurrencyInfo
	{
		[ProtoMember(1)]
		[XmlText]
		public string Location;

		[ProtoMember(2)]
		[XmlAttribute]
		public string Currency;

		[ProtoMember(3)]
		[XmlAttribute]
		public int LocationID;

		[ProtoMember(4)]
		[XmlAttribute]
		public int CountryLocationID;
	}
}
