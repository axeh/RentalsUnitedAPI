using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[ProtoContract]
	[XmlType("FSPSeason")]
	public class FSPSeasonInfo : IEquatable<FSPSeasonInfo>
	{
		[XmlAttribute(DataType = "date")]
		[ProtoMember(1)]
		public DateTime Date;

		[ProtoMember(2)]
		[XmlAttribute]
		public decimal DefaultPrice;

		[XmlIgnore]
		[ProtoIgnore]
		public bool DefaultPriceSpecified;

		[XmlArray]
		[ProtoMember(3)]
		public List<FSPRow> FSPRows;

		[XmlIgnore]
		[OptionalField]
		[ProtoMember(4)]
		public int ID;

		[XmlIgnore]
		[ProtoMember(5)]
		public string SeasonName;

		[XmlIgnore]
		public bool RemoveSeason
		{
			get
			{
				if (DefaultPrice <= 0m)
				{
					if (FSPRows != null)
					{
						return FSPRows.Count == 0;
					}
					return true;
				}
				return false;
			}
		}

		public override bool Equals(object obj)
		{
			if (obj is FSPSeasonInfo)
			{
				return Equals(obj as FSPSeasonInfo);
			}
			return false;
		}

		public bool Equals(FSPSeasonInfo other)
		{
			if (Date == other.Date && DefaultPrice == other.DefaultPrice)
			{
				return EqualityComparer<List<FSPRow>>.Default.Equals(FSPRows, other.FSPRows);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return ((-3 * -1 + Date.GetHashCode()) * -4 + DefaultPrice.GetHashCode()) * -5 + EqualityComparer<List<FSPRow>>.Default.GetHashCode(FSPRows);
		}
	}
}
