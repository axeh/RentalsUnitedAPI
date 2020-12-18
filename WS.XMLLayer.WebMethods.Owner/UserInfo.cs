using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Owner
{
	[XmlType("User")]
	public class UserInfo
	{
		public string UserName;

		public string Password;
	}
}
