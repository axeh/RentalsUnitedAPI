using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	[XmlType("ChangeType")]
	public class LiveNotificationMechanismChangeTypeDescriptionInfo
	{
		public string Description;

		public string ExampleUrl;

		[XmlAttribute]
		public string ID;
	}
}
