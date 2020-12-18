using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("ReservationSimple")]
	public class ReservationSimple
	{
		private Dictionary<int, int> dbStatusToApiStatus = new Dictionary<int, int>
		{
			{
				5,
				1
			},
			{
				8,
				2
			}
		};

		public string Source;

		public int PropertyID
		{
			get;
			set;
		}

		public int ResapaId
		{
			get;
			set;
		}

		public int LocationId
		{
			get;
			set;
		}

		public int StatusId
		{
			get;
			set;
		}

		public string PropertyName
		{
			get;
			set;
		}

		[XmlIgnore]
		public DateTime DateFrom
		{
			get;
			set;
		}

		[XmlIgnore]
		public DateTime DateTo
		{
			get;
			set;
		}

		[XmlElement(ElementName = "DateFrom")]
		public string DateFromString
		{
			get;
			set;
		}

		[XmlElement(ElementName = "DateTo")]
		public string DateToString
		{
			get;
			set;
		}

		public int NumberOfPeople
		{
			get;
			set;
		}

		public decimal BookingTotal
		{
			get;
			set;
		}

		public int DbStatusToApiStatus()
		{
			dbStatusToApiStatus.TryGetValue(StatusId, out int value);
			return value;
		}
	}
}
