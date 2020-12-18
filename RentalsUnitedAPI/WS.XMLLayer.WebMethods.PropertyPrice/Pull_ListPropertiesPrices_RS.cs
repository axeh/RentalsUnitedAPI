using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyPrice
{
	public class Pull_ListPropertiesPrices_RS : BaseResponse
	{
		[XmlArray]
		public List<PricesInfo> Properties;
	}
}
