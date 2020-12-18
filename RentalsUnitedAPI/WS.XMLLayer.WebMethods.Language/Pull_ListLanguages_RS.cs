using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Language
{
	public class Pull_ListLanguages_RS : BaseResponse
	{
		[XmlArray]
		public List<LanguageInfo> Languages;
	}
}
