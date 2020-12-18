using ProtoBuf;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Location
{
	[ProtoContract]
	[XmlType("Location")]
	public class LocationInfo
	{
		[ProtoMember(1)]
		[XmlText]
		public string Location;

		[ProtoMember(2)]
		[XmlAttribute]
		public int LocationID;

		[ProtoMember(3)]
		[XmlAttribute]
		public int LocationTypeID;

		[ProtoMember(4)]
		[XmlAttribute]
		public int ParentLocationID = -1;
	}
}
