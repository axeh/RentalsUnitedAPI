using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("CheckInOut")]
	public class CheckInOutInfo
	{
		public string CheckInFrom;

		public string CheckInTo;

		public string CheckOutUntil;

		public string Place;

		[XmlArray]
		public List<LateArrivalFeeInfo> LateArrivalFees;

		[XmlArray]
		public List<EarlyDepartureFeeInfo> EarlyDepartureFees;

		public const string DefaultCheckInFrom = "14:00";

		public const string DefaultCheckInTo = "17:00";

		public const string DefaultCheckOutUntil = "11:00";

		public const string DefaultPlace = "-- default place --";

		public CheckInOutInfo()
		{
			CheckInFrom = "14:00";
			CheckInTo = "17:00";
			CheckOutUntil = "11:00";
			Place = "-- default place --";
			LateArrivalFees = null;
			EarlyDepartureFees = null;
		}
	}
}
