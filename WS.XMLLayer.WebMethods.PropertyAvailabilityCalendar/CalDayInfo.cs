using ProtoBuf;
using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar
{
	[ProtoContract]
	public class CalDayInfo
	{
		[XmlAttribute(DataType = "date")]
		[ProtoMember(1)]
		public DateTime Date;

		[ProtoMember(2)]
		public bool IsBlocked;

		[ProtoMember(3)]
		public int MinStay;

		[ProtoMember(4)]
		public int Changeover;

		[XmlAttribute]
		[ProtoMember(5, IsRequired = false)]
		public int Units;

		[XmlAttribute]
		[ProtoMember(6, IsRequired = false)]
		public int Reservations;
	}
}
