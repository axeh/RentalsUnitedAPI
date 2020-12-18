using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Changeover
{
	[XmlType("ChangeoverType")]
	public class ChangeoverTypeInfo
	{
		[XmlAttribute]
		public int ID;

		[XmlText]
		public string Description;
	}
}
