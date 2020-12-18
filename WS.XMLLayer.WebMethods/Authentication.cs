using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	public class Authentication
	{
		public string UserName;

		public string Password;

		[XmlIgnore]
		public int UserID;
	}
}
