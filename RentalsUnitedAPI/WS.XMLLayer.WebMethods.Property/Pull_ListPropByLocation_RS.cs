using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Pull_ListPropByLocation_RS : BaseResponse
	{
		[XmlArray]
		public List<PropByLocation> Result;
	}
}
