using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	public class Pull_ListCitiesProps_RS : BaseResponse
	{
		[XmlArray]
		public List<CityPropsInfo> CitiesProps;
	}
}
