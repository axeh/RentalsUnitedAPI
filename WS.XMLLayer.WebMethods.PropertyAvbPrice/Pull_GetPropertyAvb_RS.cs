using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyAvbPrice
{
	public class Pull_GetPropertyAvb_RS : BaseResponse
	{
		public bool IsAvailable;

		[XmlAttribute]
		public int Units;
	}
}
