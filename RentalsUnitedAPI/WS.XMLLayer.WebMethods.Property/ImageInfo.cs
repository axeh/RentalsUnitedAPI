using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Image")]
	public class ImageInfo
	{
		[XmlText]
		public string Image;

		[XmlAttribute]
		public int ImageTypeID;

		[XmlAttribute]
		public string ImageReferenceID;

		[XmlIgnore]
		public int? Order;

		[XmlIgnore]
		public long ImageID;
	}
}
