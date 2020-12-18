using ProtoBuf;
using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	[ProtoContract]
	[ProtoInclude(3, typeof(ExtendedBlockInfo))]
	public class BlockInfo
	{
		[XmlElement(DataType = "date")]
		[ProtoMember(1)]
		public DateTime DateFrom;

		[XmlElement(DataType = "date")]
		[ProtoMember(2)]
		public DateTime DateTo;
	}
}
