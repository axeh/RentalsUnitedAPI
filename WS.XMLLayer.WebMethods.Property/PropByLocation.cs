using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Rental")]
	public class PropByLocation
	{
		public string Name
		{
			get;
			set;
		}

		public string Lat
		{
			get;
			set;
		}

		public string Lon
		{
			get;
			set;
		}

		public decimal Price
		{
			get;
			set;
		}

		public int CanSleepMax
		{
			get;
			set;
		}
	}
}
