namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationSimple_RQ : BaseRequest
	{
		public string User;

		public string DateFrom;

		public string DateTo;

		public int LocationID;
	}
}
