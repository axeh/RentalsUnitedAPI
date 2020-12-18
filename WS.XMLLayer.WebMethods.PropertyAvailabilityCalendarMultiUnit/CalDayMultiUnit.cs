using ProtoBuf;
using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	[ProtoContract]
	public class CalDayMultiUnit
	{
		[XmlAttribute(DataType = "date")]
		[ProtoMember(1)]
		public DateTime Date;

		[ProtoMember(2)]
		public int NumberOfAvailableUnits;

		[ProtoMember(3)]
		public int MinStay;

		[ProtoMember(4)]
		public bool CheckInPossible;

		[ProtoMember(5)]
		public bool CheckOutPossible;

		[ProtoMember(6)]
		public int NoOfHBUs;

		[ProtoMember(7)]
		public int NoOfReses;

		public override string ToString()
		{
			return $"{Date.ToShortDateString()} Units:{NumberOfAvailableUnits} Min:{MinStay} In:{CheckInPossible} Out:{CheckOutPossible} hbu:{NoOfHBUs} r{NoOfReses}";
		}
	}
}
