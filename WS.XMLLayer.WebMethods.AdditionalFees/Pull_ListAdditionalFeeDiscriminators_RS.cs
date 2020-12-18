using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class Pull_ListAdditionalFeeDiscriminators_RS : BaseResponse
	{
		[XmlArray]
		public List<AdditionalFeeDiscriminatorInfo> AdditionalFeeDiscriminators;

		public Pull_ListAdditionalFeeDiscriminators_RS()
		{
			AdditionalFeeDiscriminators = new List<AdditionalFeeDiscriminatorInfo>();
		}
	}
}
