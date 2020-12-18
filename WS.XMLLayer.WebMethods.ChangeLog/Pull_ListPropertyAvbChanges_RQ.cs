using System;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	public class Pull_ListPropertyAvbChanges_RQ : BaseRequest
	{
		public int PropertyID;

		public DateTime Since;
	}
}
