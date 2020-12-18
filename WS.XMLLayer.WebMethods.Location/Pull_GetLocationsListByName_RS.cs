using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	public class Pull_GetLocationsListByName_RS : BaseResponse
	{
		[XmlArray]
		public List<LocationWithCurrencyInfo> Locations;
	}
}
