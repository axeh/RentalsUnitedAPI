using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class Pull_CancellationTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<CancellationType> CancellationTypes
		{
			get;
			set;
		}
	}
}
