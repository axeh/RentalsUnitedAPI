using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetPropertyAvb_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public int NOP;
	}
}
