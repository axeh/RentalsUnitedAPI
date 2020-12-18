namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_ListReservationsOwnerUser_RS : Pull_ListReservations_RS
	{
		public Pull_ListReservationsOwnerUser_RS()
		{
		}

		public Pull_ListReservationsOwnerUser_RS(Pull_ListReservations_RS res)
		{
			Status = res.Status;
			ResponseId = res.ResponseId;
			Reservations = res.Reservations;
		}
	}
}
