using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Language
{
	[XmlType("Language")]
	public class LanguageInfo
	{
		[XmlAttribute]
		public int LanguageID;

		[XmlAttribute]
		public string LanguageCode;

		[XmlText]
		public string Name;
	}
}
