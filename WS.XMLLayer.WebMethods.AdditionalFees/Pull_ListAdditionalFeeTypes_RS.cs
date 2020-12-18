using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class Pull_ListAdditionalFeeTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<AdditionalFeeTypeInfo> AdditionalFeeTypes;

		public Pull_ListAdditionalFeeTypes_RS()
		{
			AdditionalFeeTypes = new List<AdditionalFeeTypeInfo>();
		}
	}
}
