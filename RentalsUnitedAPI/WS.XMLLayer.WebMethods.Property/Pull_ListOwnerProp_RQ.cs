namespace WS.XMLLayer.WebMethods.Property
{
	public class Pull_ListOwnerProp_RQ : BaseRequest
	{
		public int OwnerID;

		public string Username;

		public bool IncludeNLA = true;
	}
}
