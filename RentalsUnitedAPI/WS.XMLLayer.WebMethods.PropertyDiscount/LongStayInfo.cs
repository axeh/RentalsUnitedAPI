using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyDiscount
{
	[XmlType("LongStay")]
	[ProtoContract]
	public class LongStayInfo : IEquatable<LongStayInfo>
	{
		[XmlAttribute]
		[OptionalField]
		[ProtoMember(1)]
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
		public int Smaller;

		[XmlAttribute]
		[ProtoMember(5)]
		public int Bigger;

		[XmlText]
		[ProtoMember(6)]
		public int LongStay;

		public bool Equals(LongStayInfo other)
		{
			if (DateFrom != other.DateFrom)
			{
				return false;
			}
			if (DateTo != other.DateTo)
			{
				return false;
			}
			if (Bigger != other.Bigger)
			{
				return false;
			}
			if (Smaller != other.Smaller)
			{
				return false;
			}
			return true;
		}
	}
}
