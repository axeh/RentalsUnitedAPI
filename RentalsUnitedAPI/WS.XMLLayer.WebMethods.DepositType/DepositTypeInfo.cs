using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.DepositType
{
	[XmlType("DepositType")]
	public class DepositTypeInfo
	{
		[XmlText]
		public string DepostitType;

		[XmlAttribute]
		public int DepositTypeID;
	}
}
