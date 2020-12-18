using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PaymentMethod
{
	[XmlType("PaymentMethod")]
	public class PaymentMethodInfo
	{
		[XmlText]
		public string PaymentMethod;

		[XmlAttribute]
		public int PaymentMethodID;
	}
}
