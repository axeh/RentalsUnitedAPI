using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Currency
{
	[XmlType("Currency")]
	public class CurrencyInfo
	{
		[XmlAttribute]
		public string CurrencyCode;

		[XmlArray]
		public List<LocationIDInfo> Locations;
	}
}
