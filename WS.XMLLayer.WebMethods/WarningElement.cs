using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	public class WarningElement
	{
		[XmlAttribute]
		public int StatusID;

		[XmlText]
		public string Notif;

		public WarningElement()
		{
		}

		public WarningElement(int statusID)
		{
			StatusID = statusID;
			Notif = StatusInfo.GetStatus(statusID).Status;
		}
	}
}
