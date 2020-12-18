using ProtoBuf;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.User
{
	[ProtoContract]
	[XmlType("User")]
	public class UserInformation
	{
		[ProtoMember(1)]
		public int UserId;

		[ProtoMember(2)]
		public string Username;
	}
}
