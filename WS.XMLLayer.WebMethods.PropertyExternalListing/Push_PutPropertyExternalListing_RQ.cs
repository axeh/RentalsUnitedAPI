using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalListing
{
	public class Push_PutPropertyExternalListing_RQ : BaseRequest
	{
		[XmlArray]
		public List<PropertyPutInfo> Properties;
	}
}
