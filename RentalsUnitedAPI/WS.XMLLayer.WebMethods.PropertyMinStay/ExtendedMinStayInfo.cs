using ProtoBuf;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyMinStay
{
	[ProtoContract]
	public class ExtendedMinStayInfo : MinStayInfo
	{
		[XmlAttribute]
		[ProtoMember(1)]
		public int Id
		{
			get;
			set;
		}

		[XmlAttribute]
		[ProtoMember(2)]
		public int GapBehaviour
		{
			get;
			set;
		}

		[XmlAttribute]
		[ProtoMember(3)]
		public int IgnoreIfLastMinute
		{
			get;
			set;
		}

		[XmlAttribute]
		[ProtoMember(4)]
		public string Comment
		{
			get;
			set;
		}

		public ExtendedMinStayInfo()
		{
			IgnoreIfLastMinute = -1;
		}
	}
}
