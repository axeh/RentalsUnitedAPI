using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyReview
{
	public class ReviewTranslation
	{
		[XmlAttribute]
		public int LanguageID;

		[XmlText]
		public string Value;
	}
}
