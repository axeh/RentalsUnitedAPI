using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_QuoteModes_RS : BaseResponse
	{
		[XmlArray]
		public List<QuoteModeObject> QuoteModes
		{
			get;
			set;
		}
	}
}
