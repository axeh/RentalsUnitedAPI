using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Push_SetPropertiesStatus_RQ : BaseRequest
	{
		public bool IsActive;

		public bool IsArchived;

		[XmlArray]
		[XmlArrayItem("PropertyID")]
		public List<int> PropertyIDs;
	}
}
