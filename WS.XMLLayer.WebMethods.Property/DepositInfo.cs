using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Deposit")]
	public class DepositInfo
	{
		[XmlText]
		public decimal Deposit;

		[XmlAttribute]
		public int DepositTypeID;
	}
}
