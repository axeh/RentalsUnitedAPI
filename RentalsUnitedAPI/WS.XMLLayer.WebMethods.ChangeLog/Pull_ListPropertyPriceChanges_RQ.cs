using System;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	public class Pull_ListPropertyPriceChanges_RQ : BaseRequest
	{
		public int PropertyID;

		public DateTime Since;
	}
}
