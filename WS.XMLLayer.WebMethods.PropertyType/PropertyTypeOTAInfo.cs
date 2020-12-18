using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyType
{
	[XmlType("PropertyType")]
	public class PropertyTypeOTAInfo
	{
		[XmlAttribute]
		public int PropertyTypeID;

		[XmlText]
		public string PropertyType;

		[XmlAttribute]
		public int OTACode;
	}
}
