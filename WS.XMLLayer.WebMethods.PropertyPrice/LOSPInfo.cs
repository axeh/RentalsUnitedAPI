using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[XmlType("LOSP")]
	[ProtoContract]
	public class LOSPInfo : IEquatable<LOSPInfo>
	{
		[OptionalField]
		[ProtoMember(1)]
		public int ID;

		[XmlIgnore]
		[ProtoIgnore]
		public bool IDSpecified;

		[XmlAttribute]
		[ProtoMember(2)]
		public int NrOfGuests;

		[ProtoMember(3)]
		public decimal Price;

		public bool Equals(LOSPInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return NrOfGuests == other.NrOfGuests;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (obj.GetType() != GetType())
			{
				return false;
			}
			return Equals((LOSPInfo)obj);
		}

		public override int GetHashCode()
		{
			return NrOfGuests;
		}
	}
}
