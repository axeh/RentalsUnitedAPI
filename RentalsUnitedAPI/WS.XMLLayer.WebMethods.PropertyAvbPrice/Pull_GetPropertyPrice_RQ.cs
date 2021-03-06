using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetPropertyPrice_RQ : BaseRequest
	{
		public int PropertyID;

		public string Currency;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public int? NOP;
	}
}
