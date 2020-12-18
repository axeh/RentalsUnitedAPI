using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class PropertyCount
	{
		[XmlAttribute]
		public int Count
		{
			get;
			set;
		}

		[XmlAttribute]
		public int Active
		{
			get;
			set;
		}
	}
}
