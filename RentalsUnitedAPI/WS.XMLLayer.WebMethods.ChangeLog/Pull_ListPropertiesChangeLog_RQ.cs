using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	public class Pull_ListPropertiesChangeLog_RQ : BaseRequest
	{
		[XmlArray]
		[XmlArrayItem("PropertyID")]
		public List<int> PropertyIDs;
	}
}
