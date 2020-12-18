using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	[XmlType("Type")]
	public class LiveNotificationMechanismChangeTypeInfo
	{
		[XmlText]
		public string Value
		{
			get;
			set;
		}
	}
}
