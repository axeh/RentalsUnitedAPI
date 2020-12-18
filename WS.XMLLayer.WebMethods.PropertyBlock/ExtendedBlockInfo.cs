using ProtoBuf;
using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	[ProtoContract]
	public class ExtendedBlockInfo : BlockInfo
	{
		[ProtoMember(1)]
		public int ReservationLID
		{
			get;
			set;
		}

		[ProtoMember(2)]
		public int ResApaID
		{
			get;
			set;
		}

		[ProtoMember(3)]
		public int StatusID
		{
			get;
			set;
		}

		[ProtoMember(4)]
		public int CityID
		{
			get;
			set;
		}

		[ProtoMember(5)]
		public string ReservationCreator
		{
			get;
			set;
		}

		[ProtoMember(6)]
		public DateTime ResApaDateChanged
		{
			get;
			set;
		}

		[ProtoMember(7)]
		public DateTime ReservationDateEntered
		{
			get;
			set;
		}

		[XmlElement(DataType = "date")]
		[ProtoMember(8)]
		public DateTime RealDateFrom
		{
			get;
			set;
		}

		[XmlElement(DataType = "date")]
		[ProtoMember(9)]
		public DateTime RealDateTo
		{
			get;
			set;
		}

		public ExtendedBlockInfo Copy()
		{
			return new ExtendedBlockInfo
			{
				CityID = CityID,
				RealDateFrom = RealDateFrom,
				RealDateTo = RealDateTo,
				ResApaID = ResApaID,
				ReservationLID = ReservationLID,
				StatusID = StatusID,
				ResApaDateChanged = ResApaDateChanged,
				ReservationCreator = ReservationCreator,
				DateFrom = DateFrom,
				DateTo = DateTo,
				ReservationDateEntered = ReservationDateEntered
			};
		}

		public override string ToString()
		{
			return $"{RealDateFrom}-{RealDateTo}; {ResApaID}";
		}
	}
}
