using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBaseRate
{
	public class BasePriceInfo
	{
		[XmlAttribute]
		public int DayOfWeek;

		[XmlAttribute]
		public decimal Price;

		[XmlAttribute]
		public decimal Extra;
	}
}
