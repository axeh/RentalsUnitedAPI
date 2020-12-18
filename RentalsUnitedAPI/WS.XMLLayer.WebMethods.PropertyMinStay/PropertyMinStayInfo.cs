using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyMinStay
{
	[XmlType("PropertyMinStay")]
	public class PropertyMinStayInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("MinStay")]
		public List<MinStayInfo> MinStays;
	}
}
