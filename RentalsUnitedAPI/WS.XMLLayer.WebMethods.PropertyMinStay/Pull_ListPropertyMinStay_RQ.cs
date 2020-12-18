using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyMinStay
{
	public class Pull_ListPropertyMinStay_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;
	}
}
