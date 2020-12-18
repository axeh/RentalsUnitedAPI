using System;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutPropertyOnHold_RQ : BaseRequest
	{
		public int PropertyID;

		public DateTime DateFrom;

		public DateTime DateTo;

		public int NumberOfGuests;
	}
}
