using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	public class Pull_ListPropertiesPrices_RQ : BaseRequest
	{
		public int LocationID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public bool IncludeNLA = true;
	}
}
