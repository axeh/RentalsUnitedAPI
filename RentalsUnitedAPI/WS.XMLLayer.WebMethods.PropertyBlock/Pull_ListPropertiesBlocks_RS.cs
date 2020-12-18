using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	public class Pull_ListPropertiesBlocks_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyBlockInfo> Properties;
	}
}
