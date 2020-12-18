using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[XmlType("EGP")]
	[ProtoContract]
	public class EGPInfo : IEquatable<EGPInfo>
	{
		[OptionalField]
		[ProtoMember(1)]
		public int ID;

		[XmlIgnore]
		[ProtoIgnore]
		public bool IDSpecified;

		[XmlAttribute]
		[ProtoMember(2)]
		public int ExtraGuests;

		[ProtoMember(3)]
		public decimal Price;

		public bool Equals(EGPInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return ExtraGuests == other.ExtraGuests;
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
			return Equals((EGPInfo)obj);
		}

		public override int GetHashCode()
		{
			return ExtraGuests;
		}
	}
}
