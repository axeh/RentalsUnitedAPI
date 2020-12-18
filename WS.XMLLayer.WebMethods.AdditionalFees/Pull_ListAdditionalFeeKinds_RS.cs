using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class Pull_ListAdditionalFeeKinds_RS : BaseResponse
	{
		[XmlArray]
		public List<AdditionalFeeKindInfo> AdditionalFeeKinds;

		public Pull_ListAdditionalFeeKinds_RS()
		{
			AdditionalFeeKinds = new List<AdditionalFeeKindInfo>();
		}
	}
}
