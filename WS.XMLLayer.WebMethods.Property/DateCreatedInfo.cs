using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("DateCreated")]
	public class DateCreatedInfo
	{
		[XmlText]
		public string DateCreated;
	}
}
