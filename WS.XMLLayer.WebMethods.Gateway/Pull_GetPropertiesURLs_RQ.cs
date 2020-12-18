using System.Collections.Generic;

namespace WS.XMLLayer.WebMethods.Gateway
{
	public class Pull_GetPropertiesURLs_RQ : BaseRequest
	{
		public List<GatewayPropertiesInfo> Properties;

		public string PageType = string.Empty;
	}
}
