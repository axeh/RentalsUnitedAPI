using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Pull_ListProp_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyInfo> Properties;
	}
}
