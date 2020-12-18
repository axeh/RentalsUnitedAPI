using System.Collections.Generic;
using System.Xml.Serialization;
using WS.XMLLayer.WebMethods.PropertyAvailabilityCalendar;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	public class Push_PutAvbUnits_RS : BaseResponse
	{
		[XmlIgnore]
		public List<AvailabilityInfo> AffectedPeriods;
	}
}
