using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	[XmlType("Owner")]
	public class LiveNotificationMechanismObservedOwnerInfo
	{
		[XmlText]
		public int Value
		{
			get;
			set;
		}
	}
}
