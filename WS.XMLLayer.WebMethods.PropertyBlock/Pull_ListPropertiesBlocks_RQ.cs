using System;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	public class Pull_ListPropertiesBlocks_RQ : BaseRequest
	{
		public int LocationID;

		public DateTime DateFrom;

		public DateTime DateTo;

		public bool IncludeNLA = true;
	}
}
