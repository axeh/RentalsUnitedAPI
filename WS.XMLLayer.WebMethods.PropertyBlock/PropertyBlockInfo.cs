using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyBlock
{
	[XmlType("PropertyBlock")]
	public class PropertyBlockInfo
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("Block")]
		public List<BlockInfo> PropertyBlocks;
	}
}
