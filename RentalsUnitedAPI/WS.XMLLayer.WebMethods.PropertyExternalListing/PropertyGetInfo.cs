using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalListing
{
	[XmlType("Property")]
	public class PropertyGetInfo
	{
		[XmlAttribute("ID")]
		public int PropertyID;

		[XmlElement("ExternalListing")]
		public List<ExternalListingInfo> ExternalListings;
	}
}
