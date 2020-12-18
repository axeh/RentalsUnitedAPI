using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Owner
{
	public class Pull_GetAgents_RS : BaseResponse
	{
		public OwnerInfo Owner;

		[XmlArray("Agents")]
		public List<AgentInfo> Agents;
	}
}
