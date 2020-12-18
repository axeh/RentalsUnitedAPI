using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	[XmlType("Warning")]
	public class WarningIdElement : WarningElement
	{
		[XmlAttribute("ID")]
		public int ID;

		public WarningIdElement()
		{
		}

		public WarningIdElement(int statusID, int id)
			: base(statusID)
		{
			ID = id;
		}
	}
}
