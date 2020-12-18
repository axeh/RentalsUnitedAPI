using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Currency
{
	public class Pull_ListCurrenciesWithCities_RS : BaseResponse
	{
		[XmlArray]
		public List<CurrencyInfo> Currencies;
	}
}
