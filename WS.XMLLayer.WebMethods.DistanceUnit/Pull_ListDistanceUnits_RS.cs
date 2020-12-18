using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.DistanceUnit
{
	public class Pull_ListDistanceUnits_RS : BaseResponse
	{
		[XmlArray]
		public List<DistanceUnitInfo> DistanceUnits;
	}
}
