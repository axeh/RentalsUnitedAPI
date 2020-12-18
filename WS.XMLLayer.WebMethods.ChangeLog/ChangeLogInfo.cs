using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	[XmlType("ChangeLog")]
	public class ChangeLogInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlAttribute]
		public bool NLA;

		[XmlAttribute]
		public bool IsActive;

		public string StaticData;

		public string Pricing;

		public string Availability;

		public string Image;

		public string Description;
	}
}
