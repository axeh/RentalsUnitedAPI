using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ChangeLog
{
	public class Pull_ListPropertyPriceChanges_RS : BaseResponse
	{
		[XmlArray]
		public List<DayInfo> PriceChanges;
	}
}
