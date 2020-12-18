using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.ImageType
{
	[XmlType("ImageType")]
	public class ImageTypeInfo
	{
		[XmlText]
		public string ImageType;

		[XmlAttribute]
		public int ImageTypeID;
	}
}
