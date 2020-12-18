using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	public class BaseResponse
	{
		public StatusInfo Status;

		[XmlElement("ResponseID")]
		public string ResponseId;

		public void SetResponseId(Guid id)
		{
			ResponseId = id.ToString("N");
		}
	}
}
