using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[XmlType("LOS")]
	[ProtoContract]
	public class LOSInfo : IEquatable<LOSInfo>
	{
		[OptionalField]
		[ProtoMember(1)]
		public int ID;

		[XmlIgnore]
		[ProtoIgnore]
		public bool IDSpecified;

		[XmlAttribute]
		[ProtoMember(2)]
		public int Nights;

		[ProtoMember(3)]
		public decimal Price;

		[XmlArray(IsNullable = false)]
		[ProtoMember(4)]
		public List<LOSPInfo> LOSPS;

		public bool Equals(LOSInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return Nights == other.Nights;
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
			return Equals((LOSInfo)obj);
		}

		public override int GetHashCode()
		{
			return Nights;
		}
	}
}
