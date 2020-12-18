using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	public class AvailabilityInfoMultiUnit
	{
		[XmlAttribute(DataType = "date")]
		public DateTime DateFrom;

		[XmlAttribute(DataType = "date")]
		public DateTime DateTo;

		[XmlAttribute]
		public int? NumberOfAvailableApartments;

		[XmlAttribute]
		public int? MinStay;

		[XmlAttribute]
		public bool? CheckInPossible;

		[XmlAttribute]
		public bool? CheckOutPossible;

		public override string ToString()
		{
			return string.Format("{0} - {1} a:{2} m:{3} ch:{4}{5}", DateFrom.ToString("yyyy/MM/dd"), DateTo.ToString("yyyy/MM/dd"), NumberOfAvailableApartments, MinStay, CheckInPossible, CheckOutPossible);
		}
	}
}
