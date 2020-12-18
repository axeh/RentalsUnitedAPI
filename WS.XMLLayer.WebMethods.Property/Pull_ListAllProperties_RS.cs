using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Pull_ListAllProperties_RS : BaseResponse
	{
		[XmlArray]
		public List<PropertyInfoForCRM> Properties;
	}
}
