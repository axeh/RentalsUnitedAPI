using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("LastMod")]
	public class LastModInfo
	{
		[XmlText]
		public string LastMod;

		[XmlAttribute]
		public bool NLA;
	}
}
