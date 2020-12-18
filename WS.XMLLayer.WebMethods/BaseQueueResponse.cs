namespace WS.XMLLayer.WebMethods
{
	public class BaseQueueResponse : BaseResponse
	{
		public string RequestId;

		public bool ShouldSerializeRequestId()
		{
			return !string.IsNullOrWhiteSpace(RequestId);
		}
	}
}
