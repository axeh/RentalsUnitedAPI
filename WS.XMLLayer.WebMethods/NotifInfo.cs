using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	[XmlType("Notif")]
	public class NotifInfo
	{
		[XmlIgnore]
		public DateTime DateFrom;

		[XmlIgnore]
		public DateTime DateTo;

		[XmlIgnore]
		public bool DateFromStringSpecified = true;

		[XmlIgnore]
		public bool DateToStringSpecified = true;

		[XmlAttribute]
		public int StatusID;

		[XmlText]
		public string Notif;

		[XmlAttribute]
		public int PropertyID;

		[XmlIgnore]
		public bool PropertyIDSpecified;

		[XmlAttribute]
		public int Bigger;

		[XmlIgnore]
		public bool BiggerSpecified;

		[XmlAttribute]
		public int Smaller;

		[XmlIgnore]
		public bool SmallerSpecified;

		[XmlAttribute("DateFrom")]
		public string DateFromString
		{
			get
			{
				return DateFrom.ToString("yyyy-MM-dd");
			}
			set
			{
				DateFrom = DateTime.Parse(value);
			}
		}

		[XmlAttribute("DateTo")]
		public string DateToString
		{
			get
			{
				return DateTo.ToString("yyyy-MM-dd");
			}
			set
			{
				DateTo = DateTime.Parse(value);
			}
		}

		public bool ShouldSerializeDateFromString()
		{
			if (DateFromStringSpecified)
			{
				return DateFrom > DateTime.MinValue;
			}
			return false;
		}

		public bool ShouldSerializeDateToString()
		{
			if (DateToStringSpecified)
			{
				return DateTo > DateTime.MinValue;
			}
			return false;
		}

		public NotifInfo()
		{
			PropertyIDSpecified = false;
			BiggerSpecified = false;
			SmallerSpecified = false;
		}

		public NotifInfo(DateTime dateFrom, DateTime dateTo, int statusID)
		{
			DateFrom = dateFrom;
			DateTo = dateTo;
			StatusID = statusID;
			Notif = StatusInfo.GetStatus(statusID).Status;
			PropertyIDSpecified = false;
			BiggerSpecified = false;
			SmallerSpecified = false;
		}
	}
}
