using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ImageType
{
	public class Pull_ListImageTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<ImageTypeInfo> ImageTypes;
	}
}
