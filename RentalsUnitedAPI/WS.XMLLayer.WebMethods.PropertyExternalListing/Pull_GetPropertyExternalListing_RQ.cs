using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalListing
{
	public class Pull_GetPropertyExternalListing_RQ : BaseRequest
	{
		[XmlArray]
		[XmlArrayItem("PropertyID")]
		public List<int> Properties;
	}
}
