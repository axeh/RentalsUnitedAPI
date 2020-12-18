using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[ProtoContract]
	public class SeasonInfo
	{
		[OptionalField]
		[ProtoMember(1)]
		public int ID;

		[XmlIgnore]
		[ProtoIgnore]
		public bool IDSpecified;

		[XmlAttribute(DataType = "date")]
		[ProtoMember(2)]
		public DateTime DateFrom;

		[XmlAttribute(DataType = "date")]
		[ProtoMember(3)]
		public DateTime DateTo;

		[ProtoMember(4)]
		public decimal Price;

		[ProtoMember(5)]
		public decimal Extra;

		[XmlArray(IsNullable = false)]
		[ProtoMember(6)]
		public List<LOSInfo> LOSS;

		[XmlArray(IsNullable = false)]
		[ProtoMember(7)]
		public List<EGPInfo> EGPS;

		[XmlIgnore]
		[ProtoMember(8)]
		public string SeasonName;

		[XmlIgnore]
		[ProtoMember(9)]
		public bool SeasonsAreOverlapping;

		[DefaultValue(false)]
		[ProtoMember(10)]
		public bool RemoveSeason;
	}
}
