using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("Reservation")]
	public class ReservationInfo
	{
		[XmlAttribute]
		public string Currency;

		[XmlElement(IsNullable = true)]
		public int? ReservationID;

		[XmlElement(IsNullable = false)]
		public StatusIDInfo StatusID;

		[XmlElement(IsNullable = false)]
		public LastModInfo LastMod;

		[XmlArray]
		public List<StayInfo2> StayInfos;

		public CustomerInfo CustomerInfo;

		public string Creator;

		public string Comments;

		public string PMSReservationId;

		[XmlElement(IsNullable = false)]
		public CreditCardInfo CreditCard;

		public int ReservationStatusID;

		[XmlIgnore]
		public bool ReservationStatusIDSpecified;

		[XmlIgnore]
		public int CID;

		public string ReferenceID;

		[XmlIgnore]
		public CancelType? CanceledBy;

		public bool IsArchived;

		[XmlElement("CancelTypeID")]
		public int? CancelByID
		{
			get
			{
				return (int?)CanceledBy;
			}
			set
			{
				CanceledBy = (CancelType?)value;
			}
		}

		[XmlIgnore]
		public bool CancelByIDSpecified => CancelByID.HasValue;
	}
}
