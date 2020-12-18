using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	[XmlType("Warning")]
	public class WarningPeriodElement : WarningElement
	{
		[XmlIgnore]
		public DateTime DateFrom;

		[XmlIgnore]
		public DateTime DateTo;

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

		public WarningPeriodElement()
		{
		}

		public WarningPeriodElement(int statusID, DateTime dateFrom, DateTime dateTo)
			: base(statusID)
		{
			DateFrom = dateFrom;
			DateTo = dateTo;
		}
	}
}
