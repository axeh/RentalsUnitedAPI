using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	[XmlType("LastMinute")]
	[ProtoContract]
	public class LastMinuteInfo
	{
		[XmlAttribute]
		[ProtoMember(1)]
		[OptionalField]
		public int ApartmentID;

		[XmlIgnore]
		[ProtoIgnore]
		public bool ApartmentIDSpecified;

		[XmlAttribute(DataType = "date")]
		[ProtoMember(2)]
		public DateTime DateFrom;

		[XmlAttribute(DataType = "date")]
		[ProtoMember(3)]
		public DateTime DateTo;

		[XmlAttribute]
		[ProtoMember(4)]
		public int DaysToArrivalFrom;

		[XmlAttribute]
		[ProtoMember(5)]
		public int DaysToArrivalTo;

		[XmlText]
		[ProtoMember(6)]
		public int LastMinute;
	}
}
