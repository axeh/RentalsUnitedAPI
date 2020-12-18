using ProtoBuf;
using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyMinStay
{
	[ProtoContract]
	[ProtoInclude(4, typeof(ExtendedMinStayInfo))]
	public class MinStayInfo
	{
		[XmlAttribute(DataType = "date")]
		[ProtoMember(1)]
		public DateTime DateFrom;

		[XmlAttribute(DataType = "date")]
		[ProtoMember(2)]
		public DateTime DateTo;

		[XmlText]
		[ProtoMember(3)]
		public int MinStay;
	}
}
