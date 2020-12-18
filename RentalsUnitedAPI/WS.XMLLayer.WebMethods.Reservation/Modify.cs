using System;
using System.Globalization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Modify
	{
		public string PropertyID;

		public string DateFrom;

		public string DateTo;

		public string NumberOfGuests;

		public string ClientPrice;

		public string AlreadyPaid;

		public string PMSReservationId;

		[XmlIgnore]
		public bool HasProperty => !string.IsNullOrEmpty(PropertyID);

		[XmlIgnore]
		public bool HasDateFrom => !string.IsNullOrEmpty(DateFrom);

		[XmlIgnore]
		public bool HasDateTo => !string.IsNullOrEmpty(DateTo);

		[XmlIgnore]
		public bool HasNumberOfGuests => !string.IsNullOrEmpty(NumberOfGuests);

		[XmlIgnore]
		public bool HasClientPrice => !string.IsNullOrEmpty(ClientPrice);

		[XmlIgnore]
		public bool HasAlreadyPaid => !string.IsNullOrEmpty(AlreadyPaid);

		[XmlIgnore]
		public bool HasPMSReservationId => !string.IsNullOrEmpty(PMSReservationId);

		public bool GetApartmentID(out int apartmentID)
		{
			return int.TryParse(PropertyID, out apartmentID);
		}

		public bool GetDateFrom(out DateTime dateFrom)
		{
			return DateTime.TryParseExact(DateFrom, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFrom);
		}

		public bool GetDateTo(out DateTime dateTo)
		{
			return DateTime.TryParseExact(DateTo, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTo);
		}

		public bool GetNumberOfGuests(out int numberOfGuests)
		{
			return int.TryParse(NumberOfGuests, out numberOfGuests);
		}

		public bool GetClientPrice(out decimal clientPrice)
		{
			if (!decimal.TryParse(ClientPrice, NumberStyles.Number, CultureInfo.InvariantCulture, out clientPrice))
			{
				clientPrice = -1m;
				return false;
			}
			return true;
		}

		public bool GetAlreadyPaid(out decimal alreadyPaid)
		{
			if (!decimal.TryParse(AlreadyPaid, NumberStyles.Number, CultureInfo.InvariantCulture, out alreadyPaid))
			{
				alreadyPaid = -1m;
				return false;
			}
			return true;
		}
	}
}
