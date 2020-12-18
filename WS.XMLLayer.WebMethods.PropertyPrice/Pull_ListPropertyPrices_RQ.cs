using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	public class Pull_ListPropertyPrices_RQ : BaseRequest
	{
		public int PropertyID;

		public string Currency;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public int? PricingModelMode;
	}
}
