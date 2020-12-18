using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyType
{
	public class Pull_ListPropTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyTypeInfo> PropertyTypes;
	}
}
