using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("StayInfo")]
	public class StayInfo2
	{
		public int PropertyID
		{
			get;
			set;
		}

		public string XmlApartmentID
		{
			get;
			set;
		}

		[XmlElement(DataType = "date")]
		public DateTime DateFrom
		{
			get;
			set;
		}

		[XmlElement(DataType = "date")]
		public DateTime DateTo
		{
			get;
			set;
		}

		public int NumberOfGuests
		{
			get;
			set;
		}

		public CostsInfo Costs
		{
			get;
			set;
		}

		public int ResapaID
		{
			get;
			set;
		}

		[XmlIgnore]
		public bool ResapaIDSpecified
		{
			get;
			set;
		}

		public string Comments
		{
			get;
			set;
		}

		public Mapping Mapping
		{
			get;
			set;
		}

		public int Units
		{
			get;
			set;
		}

		public StayInfo2()
		{
			Units = 1;
		}
	}
}
