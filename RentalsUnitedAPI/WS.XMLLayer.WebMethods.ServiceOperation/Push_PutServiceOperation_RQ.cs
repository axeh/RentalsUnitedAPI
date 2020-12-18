namespace WS.XMLLayer.WebMethods.ServiceOperation
{
	public class Push_PutServiceOperation_RQ : BaseRequest
	{
		public int ServiceID
		{
			get;
			set;
		}

		public int ResapaID
		{
			get;
			set;
		}

		public int SetForUserID
		{
			get;
			set;
		}

		public string AdditionalData
		{
			get;
			set;
		}
	}
}
