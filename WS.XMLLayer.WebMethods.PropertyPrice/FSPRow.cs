using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[ProtoContract]
	[XmlType("FSPRow")]
	public class FSPRow : IEquatable<FSPRow>
	{
		[XmlAttribute]
		[ProtoMember(1)]
		public int NrOfGuests;

		[XmlArray]
		[ProtoMember(2)]
		public List<PricePerNight> Prices;

		public override bool Equals(object obj)
		{
			if (obj is FSPRow)
			{
				return Equals(obj as FSPRow);
			}
			return false;
		}

		public bool Equals(FSPRow other)
		{
			if (NrOfGuests == other.NrOfGuests)
			{
				return Prices.SequenceEqual(other.Prices);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (-2 * -5 + NrOfGuests.GetHashCode()) * -5 + EqualityComparer<List<PricePerNight>>.Default.GetHashCode(Prices);
		}
	}
}
