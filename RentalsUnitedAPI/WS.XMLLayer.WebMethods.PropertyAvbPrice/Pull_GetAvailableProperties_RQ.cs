using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetAvailableProperties_RQ : BaseRequest
	{
		public int LocationID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;

		public int NOP;

		public bool IncludeNLA = true;
	}
}
