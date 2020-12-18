namespace WS.XMLLayer.WebMethods.Property
{
	public class Push_StandardNumberOfGuests_RS : BaseQueueResponse
	{
		public int ID;

		public bool ShouldSerializeID()
		{
			return ID > 0;
		}
	}
}
