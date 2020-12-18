using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	public class URLWithParams
	{
		[XmlAttribute("value")]
		public string url;

		[XmlElement("Param")]
		public List<URLParam> Param;
	}
}
