using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Gateway
{
	public class Push_PutPropertiesURLs_RQ : BaseRequest
	{
		[XmlElement("PropertyURL")]
		public GatewayPushPropertyURL[] PropertyURL;
	}
}
