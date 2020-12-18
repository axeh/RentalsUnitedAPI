namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_ModifyStay_RQ : BaseRequest
	{
		public int ReservationID;

		public Current Current;

		public Modify Modify;

		public bool AllowOverbooking;
	}
}
