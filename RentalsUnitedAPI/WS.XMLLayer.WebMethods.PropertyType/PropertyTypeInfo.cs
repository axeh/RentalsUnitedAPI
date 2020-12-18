using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyType
{
	[XmlType("PropertyType")]
	public class PropertyTypeInfo
	{
		[XmlText]
		public string PropertyType;

		[XmlAttribute]
		public int PropertyTypeID;
	}
}
