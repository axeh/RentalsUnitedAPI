using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PaymentMethod
{
	public class Pull_ListPaymentMethods_RS : BaseResponse
	{
		[XmlArray]
		public List<PaymentMethodInfo> PaymentMethods;
	}
}
