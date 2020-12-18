namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationsSubUsers_RQ : BaseRequest
	{
		public string DateFrom;

		public string DateTo;

		public int LocationID;

		public string User;

		public bool Extended;
	}
}
