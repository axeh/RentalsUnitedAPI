using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	[XmlType("Prices")]
	public class PricesInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlAttribute]
		public string Currency;

		[XmlElement("Season")]
		public List<SeasonInfo> Seasons;

		public List<FSPSeasonInfo> FSPSeasons;
	}
}
