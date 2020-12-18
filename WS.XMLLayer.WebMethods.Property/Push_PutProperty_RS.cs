using System.Collections.Generic;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Push_PutProperty_RS : BaseQueueResponse
	{
		public int ID;

		public List<NotifInfo> Notifs;

		public bool ShouldSerializeID()
		{
			return ID > 0;
		}
	}
}
