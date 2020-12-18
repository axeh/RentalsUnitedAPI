using System;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Pull_ListPropByCreationDate_RQ : BaseRequest
	{
		public DateTime CreationFrom;

		public DateTime CreationTo;

		public bool IncludeNLA = true;
	}
}
