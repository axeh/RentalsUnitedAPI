using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("OnHold")]
	public class OnHoldInfo
	{
		public int PropertyID;

		public DateTime DateFrom;

		public DateTime DateTo;

		public int NumberOfGuests;

		public int Units = 1;
	}
}
