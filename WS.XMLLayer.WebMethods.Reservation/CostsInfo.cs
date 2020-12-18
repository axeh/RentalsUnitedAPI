using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class CostsInfo
	{
		public decimal RUPrice;

		public decimal ClientPrice;

		public decimal AlreadyPaid;

		public string PriceScale;

		[XmlIgnore]
		public bool PriceScaleSpecified;
	}
}
