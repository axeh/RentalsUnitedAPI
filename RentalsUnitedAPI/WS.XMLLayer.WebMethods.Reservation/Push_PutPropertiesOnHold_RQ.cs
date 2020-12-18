using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Push_PutPropertiesOnHold_RQ : BaseRequest
	{
		[XmlArray]
		public List<OnHoldInfo> OnHolds;
	}
}
