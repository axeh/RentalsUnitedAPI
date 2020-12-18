using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Status
{
	public class Pull_ListStatuses_RS : BaseResponse
	{
		[XmlArray]
		public List<StatusInfo> Statuses;
	}
}
