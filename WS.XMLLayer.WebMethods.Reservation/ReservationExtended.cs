using System;
using System.Globalization;
using System.Xml.Serialization;
using WS.XMLLayer.WebMethods.Property;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("ReservationExtended")]
	public class ReservationExtended
	{
		public int ResApaID
		{
			get;
			set;
		}

		public int ReservationStatusID
		{
			get;
			set;
		}

		public int PropertyID
		{
			get;
			set;
		}

		[XmlIgnore]
		public string Latitude
		{
			set
			{
				Coordinates.Latitude = value;
			}
		}

		[XmlIgnore]
		public string Longitude
		{
			set
			{
				Coordinates.Longitude = value;
			}
		}

		public CoordinatesInfo Coordinates
		{
			get;
			set;
		}

		public string PropertyType
		{
			get;
			set;
		}

		public string Bedrooms
		{
			get;
			set;
		}

		public string Channel
		{
			get;
			set;
		}

		public int NumberOfGuests
		{
			get;
			set;
		}

		public decimal CleaningFee
		{
			get;
			set;
		}

		public decimal ADR
		{
			get;
			set;
		}

		public string Currency
		{
			get;
			set;
		}

		[XmlIgnore]
		public DateTime BookingDate
		{
			get
			{
				return DateTime.ParseExact(BookingDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			}
			set
			{
				BookingDateString = value.ToString("yyyy-MM-dd");
			}
		}

		[XmlElement(ElementName = "BookingDate")]
		public string BookingDateString
		{
			get;
			set;
		}

		[XmlIgnore]
		public DateTime CheckInDate
		{
			get
			{
				return DateTime.ParseExact(CheckInDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			}
			set
			{
				CheckInDateString = value.ToString("yyyy-MM-dd");
			}
		}

		[XmlElement(ElementName = "CheckInDate")]
		public string CheckInDateString
		{
			get;
			set;
		}

		public int LengthOfStay
		{
			get;
			set;
		}

		public string PropertyOwner
		{
			get;
			set;
		}

		public ReservationExtended()
		{
			Coordinates = new CoordinatesInfo();
		}
	}
}
