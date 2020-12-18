using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Push_SetPropertiesStatus_RS : BaseResponse
	{
		[XmlArray]
		public List<WarningIdElement> Warnings;
	}
}
