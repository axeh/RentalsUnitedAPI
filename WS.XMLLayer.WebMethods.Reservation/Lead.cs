using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Lead
	{
		public int ReservationID;

		[XmlIgnore]
		public bool ReservationIDSpecified;

		public string ExternalReservationID;

		public int PropertyID;

		public string XmlApartmentID;

		public DateTime DateFrom;

		public DateTime DateTo;

		public int NumberOfGuests;

		public CustomerInfo CustomerInfo;

		public string Comments;

		public string Creator;

		public DateTime DateEntered;

		public int Units = 1;

		[XmlIgnore]
		public int? CID;

		public bool IsArchived;

		public int ResApaID;
	}
}
