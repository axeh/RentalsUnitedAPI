using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalStatus
{
	public class Pull_ListPropExtStatuses_RS : BaseResponse
	{
		[XmlArray]
		public List<StatusInfo> PropertyExternalStatuses;
	}
}
