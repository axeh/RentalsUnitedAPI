using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("ArrivalInstructions")]
	public class ArrivalInstructionsInfo
	{
		public string Landlord;

		public string Email;

		public string Phone;

		public int DaysBeforeArrival;

		public List<ArriveDescriptionInfo> PickupService;

		public List<ArriveDescriptionInfo> HowToArrive;

		public const string DefaultLandlord = "-- default landlord --";

		public const int DefaultDaysBeforArrival = -1000;

		public const string DefaultEmail = "-- default email --";

		public const string DefaultPhone = "-- default phone --";

		public ArrivalInstructionsInfo()
		{
			Landlord = "-- default landlord --";
			DaysBeforeArrival = -1000;
			Email = "-- default email --";
			Phone = "-- default phone --";
			HowToArrive = null;
			PickupService = null;
		}
	}
}
