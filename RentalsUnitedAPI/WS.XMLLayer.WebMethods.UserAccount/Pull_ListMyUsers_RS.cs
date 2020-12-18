using System.Collections.Generic;
using WS.XMLLayer.WebMethods.Owner;

namespace WS.XMLLayer.WebMethods.UserAccount
{
	public class Pull_ListMyUsers_RS : BaseResponse
	{
		public List<OwnerInfo> Owners
		{
			get;
			set;
		}
	}
}
