using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("CreditCard")]
	public class CreditCardInfo
	{
		public string CCNumber;

		public string CVC;

		public string NameOnCard;

		public string Expiration;

		public string BillingAddress;

		public CreditCardType CardType;

		public string Comments;

		public SecureAuthentication SecureAuthentication;
	}
}
