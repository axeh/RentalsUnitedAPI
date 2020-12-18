using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("CancellationPolicyText")]
	public class CancellationPolicyTextInfo : DescriptionInfo
	{
		[OptionalField]
		public new int DomainID = 52;
	}
}
