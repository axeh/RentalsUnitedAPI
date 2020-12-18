using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvailabilityCalendarMultiUnit
{
	public class MUAvailability
	{
		[XmlAttribute("From", DataType = "date")]
		public DateTime From
		{
			get;
			set;
		}

		[XmlAttribute("To", DataType = "date")]
		public DateTime To
		{
			get;
			set;
		}

		[XmlElement("U")]
		public int NoOfAvailableUnits
		{
			get;
			set;
		}

		[XmlElement("MS")]
		public int MinStay
		{
			get;
			set;
		}

		[XmlElement("C")]
		public int Changeover
		{
			get;
			set;
		}
	}
}
