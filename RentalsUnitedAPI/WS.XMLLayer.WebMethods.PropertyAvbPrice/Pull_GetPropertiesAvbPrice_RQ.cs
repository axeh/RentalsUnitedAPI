using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetPropertiesAvbPrice_RQ : BaseRequest
	{
		public int LocationID;

		public string Currency;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public bool IncludeNLA = true;

		public int? NOP;
	}
}
