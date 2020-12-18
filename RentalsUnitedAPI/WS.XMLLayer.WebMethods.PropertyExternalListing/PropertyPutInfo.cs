using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalListing
{
	[XmlType("Property")]
	public class PropertyPutInfo : ExternalListingInfo
	{
		[XmlAttribute("ID")]
		public int PropertyID;
	}
}
