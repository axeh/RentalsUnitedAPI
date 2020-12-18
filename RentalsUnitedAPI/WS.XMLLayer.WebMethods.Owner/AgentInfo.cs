using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Owner
{
	[XmlType("Agent")]
	public class AgentInfo
	{
		public int AgentID;

		public string UserName;

		public string CompanyName;

		public string FirstName;

		public string SurName;

		public string Emial;

		public string Email;

		public string Telephone;
	}
}
