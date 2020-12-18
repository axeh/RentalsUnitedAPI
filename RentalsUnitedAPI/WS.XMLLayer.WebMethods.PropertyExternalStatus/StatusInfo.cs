using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyExternalStatus
{
	[XmlType("Status")]
	public class StatusInfo
	{
		[XmlAttribute]
		public int ID;

		[XmlText]
		public string Description;
	}
}
