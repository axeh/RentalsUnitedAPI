namespace WS.XMLLayer.WebMethods.Property
{
	public class PropertyValidator
	{
		public class Pull_GetPropertyDetailedStatus_RQ : BaseRequest
		{
			public int PropertyID;
		}

		public class Pull_GetPropertyDetailedStatus_RS : BaseResponse
		{
			public bool Location;

			public bool Prices;

			public bool Photos;

			public bool Amenities;

			public bool CheckIn;

			public bool Payment;
		}
	}
}
