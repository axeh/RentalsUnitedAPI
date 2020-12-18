using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	[XmlType("Day")]
	public class DayInfo
	{
		[XmlText]
		public string Day;
	}
}
