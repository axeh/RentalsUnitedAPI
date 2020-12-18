using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Owner
{
	public class Pull_ListAllOwners_RS : BaseResponse
	{
		[XmlArray("Owners")]
		public List<OwnerInfo> Owners;
	}
}
