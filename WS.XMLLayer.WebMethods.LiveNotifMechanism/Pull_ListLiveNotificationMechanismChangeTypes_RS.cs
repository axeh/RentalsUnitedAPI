using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	public class Pull_ListLiveNotificationMechanismChangeTypes_RS : BaseResponse
	{
		[XmlArray]
		public List<LiveNotificationMechanismChangeTypeDescriptionInfo> ChangeTypes;

		public Pull_ListLiveNotificationMechanismChangeTypes_RS()
		{
			ChangeTypes = new List<LiveNotificationMechanismChangeTypeDescriptionInfo>();
		}
	}
}
