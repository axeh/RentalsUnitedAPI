using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.LiveNotifMechanism
{
	public class Push_PutLiveNotificationMechanismSubscriptions_RQ : BaseRequest
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

		public Push_PutLiveNotificationMechanismSubscriptions_RQ()
		{
			ObservedOwners = new List<LiveNotificationMechanismObservedOwnerInfo>();
			ChangeTypes = new List<LiveNotificationMechanismChangeTypeInfo>();
		}
	}
}
