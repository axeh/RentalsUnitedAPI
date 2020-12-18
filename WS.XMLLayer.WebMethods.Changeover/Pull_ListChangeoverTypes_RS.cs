using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Changeover
{
	public class Pull_ListChangeoverTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<ChangeoverTypeInfo> ChangeoverTypes;
	}
}
