using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.UserAccount
{
	public class Push_CreateUser_RQ : BaseRequest
	{
		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		public string Password
		{
			get;
			set;
		}

		public int PMSId
		{
			get;
			set;
		}

		public string ConfigurationString
		{
			get;
			set;
		}

		[XmlArray("Locations")]
		[XmlArrayItem("LocationId")]
		public List<int> Locations
		{
			get;
			set;
		}
	}
}
