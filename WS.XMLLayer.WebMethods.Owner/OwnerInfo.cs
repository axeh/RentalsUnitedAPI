using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Owner
{
	[XmlType("Owner")]
	public class OwnerInfo
	{
		[XmlAttribute]
		public int OwnerID;

		public string FirstName;

		public string SurName;

		public string CompanyName;

		public string ScreenName;

		[XmlIgnore]
		public bool ScreenNameSpecified;

		public string Email;

		public string Phone;

		[XmlElement(IsNullable = false)]
		public UserInfo User;

		public int UserAccountId;

		public string ConfigurationString;
	}
}
