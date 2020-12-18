using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Changeover
{
	public class Push_PutChangeoverDays_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime StartDate;

		public string Changeover;
	}
}
