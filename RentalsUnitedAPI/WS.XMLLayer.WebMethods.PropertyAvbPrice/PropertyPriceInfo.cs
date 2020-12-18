//using OTA.Utilities.AdditionalFees.Calculator;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class PropertyPriceInfo
	{
		[XmlAttribute]
		public int NOP;

		[XmlAttribute]
		public decimal Cleaning;

		[XmlAttribute]
		public decimal ExtraPersonPrice;

		[XmlAttribute]
		public decimal Deposit = 0.00m;

		[XmlAttribute]
		public decimal SecurityDeposit = 0.00m;

		[XmlText]
		public decimal PropertyPrice;

		[XmlIgnore]
		public decimal PriceScale;

		[XmlAttribute]
		public decimal AdditionalFees;

		[XmlIgnore]
		public AdditionalFeesDetails AdditionalFeesDetails
		{
			get;
			set;
		}

		[XmlIgnore]
		public string Currency
		{
			get;
			set;
		}

		//[XmlIgnore]
		//public List<CalculatedFee> CalculatedFees
		//{
		//	get;
		//	set;
		//}

		//[XmlIgnore]
		//public List<CalculatedFee> CalculatedTaxes
		//{
		//	get;
		//	set;
		//}

		public PropertyPriceInfo()
		{
			AdditionalFeesDetails = new AdditionalFeesDetails();
		}
	}
}
