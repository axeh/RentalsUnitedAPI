using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyType
{
	public class Pull_ListOTAPropTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyTypeOTAInfo> PropertyTypes;
	}
}
