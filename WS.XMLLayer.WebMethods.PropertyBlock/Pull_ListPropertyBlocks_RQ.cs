using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	public class Pull_ListPropertyBlocks_RQ : BaseRequest
	{
		public int PropertyID;

		[XmlElement(DataType = "date")]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		public DateTime DateTo;
	}
}
