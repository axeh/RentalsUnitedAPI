using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	public class BaseRequest
	{
		public Authentication Authentication;

		[XmlIgnore]
		public Guid Id = Guid.NewGuid();

		public static StatusInfo ValidateInclusivePeriod(DateTime dateFrom, DateTime dateTo)
		{
			if (!(dateFrom.Date > dateTo.Date))
			{
				return null;
			}
			return StatusInfo.GetStatus(75);
		}

		public static StatusInfo ValidateExclusivePeriod(DateTime dateFrom, DateTime dateTo)
		{
			if (!(dateFrom.Date >= dateTo.Date))
			{
				return null;
			}
			return StatusInfo.GetStatus(StatusInfoCode.DateFromHasToBeEarlierThanDateTo);
		}

		public virtual void ValidateManadatoryElements()
		{
		}
	}
}
