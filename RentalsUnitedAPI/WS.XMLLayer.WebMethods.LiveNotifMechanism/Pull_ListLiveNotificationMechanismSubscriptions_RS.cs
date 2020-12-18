using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	public class Pull_ListLiveNotificationMechanismSubscriptions_RS : BaseResponse
	{
		[XmlArray]
		public List<LiveNotificationMechanismChangeTypeInfo> ChangeTypes;

		[XmlArray]
		public List<LiveNotificationMechanismObservedOwnerInfo> ObservedOwners;

		public string UrlBase
		{
			get;
			set;
		}

		public Pull_ListLiveNotificationMechanismSubscriptions_RS()
		{
			ObservedOwners = new List<LiveNotificationMechanismObservedOwnerInfo>();
			ChangeTypes = new List<LiveNotificationMechanismChangeTypeInfo>();
		}
	}
}
