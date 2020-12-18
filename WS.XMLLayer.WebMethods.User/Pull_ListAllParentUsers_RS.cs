using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.User
{
	public class Pull_ListAllParentUsers_RS : BaseResponse
	{
		[XmlArray]
		public List<UserInformation> ParentUsers;
	}
}
