namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservations_RQ : BaseRequest
	{
		public string DateFrom;

		public string DateTo;

		public int LocationID;

		public bool Extended;
	}
}
