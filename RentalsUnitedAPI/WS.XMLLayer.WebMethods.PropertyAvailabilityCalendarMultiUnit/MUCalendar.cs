//using OTA.Utilities.DateRanges;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Xml.Serialization;

//namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
//{
//	public class MUCalendar
//	{
//		[XmlAttribute("PropertyID")]
//		public int PropertyId
//		{
//			get;
//			set;
//		}

//		[XmlElement("Date")]
//		public MUAvailability[] Availability
//		{
//			get;
//			set;
//		}

//		public void MergeCommon()
//		{
//			Availability = (from avb in Availability
//				group avb by new
//				{
//					avb.NoOfAvailableUnits,
//					avb.MinStay,
//					avb.Changeover
//				}).SelectMany(avb => ((IEnumerable<DateRange>)DateRangesMerger.Merge(((IEnumerable<MUAvailability>)avb).Select((Func<MUAvailability, DateRange>)((MUAvailability a) => new DateRange(a.From, a.To))))).Select((DateRange range) => new MUAvailability
//			{
//				From = ((DateRange)(ref range)).get_DateFrom(),
//				To = ((DateRange)(ref range)).get_DateTo(),
//				NoOfAvailableUnits = avb.Key.NoOfAvailableUnits,
//				MinStay = avb.Key.MinStay,
//				Changeover = avb.Key.Changeover
//			})).ToArray();
//		}
//	}
//}
