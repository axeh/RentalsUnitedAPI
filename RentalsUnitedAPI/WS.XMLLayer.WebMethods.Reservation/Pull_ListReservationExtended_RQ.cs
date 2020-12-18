namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationExtended_RQ : BaseRequest
	{
		public string User
		{
			get;
			set;
		}

		public string ModifiedSince
		{
			get;
			set;
		}

		public int LocationID
		{
			get;
			set;
		}
	}
}
