using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Changeover
{
	public class Pull_GetChangeoverDays_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime StartDate;

		[XmlElement(DataType = "date")]
		public DateTime EndDate;
	}
}
