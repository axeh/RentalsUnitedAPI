using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.DepositType
{
	public class Pull_ListDepositTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<DepositTypeInfo> DepositTypes;
	}
}
