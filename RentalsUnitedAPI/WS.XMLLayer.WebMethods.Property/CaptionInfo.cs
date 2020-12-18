using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("ImageCaption")]
	public class CaptionInfo
	{
		[XmlText]
		public string Description;

		[XmlAttribute]
		public int LanguageID;

		[XmlAttribute]
		public string ImageReferenceID;
	}
}
