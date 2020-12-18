using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	[Serializable]
	[XmlRoot(ElementName = "error")]
	public class ErrorResponse : BaseResponse
	{
		[XmlAttribute]
		public int ID;

		[XmlText]
		public string Text;

		public static ErrorResponse BuildErrorResponse(int statusId, params object[] args)
		{
			StatusInfo status = StatusInfo.GetStatus(statusId);
			if (args.Length != 0)
			{
				status.ReplaceValue(args);
			}
			return new ErrorResponse
			{
				ID = status.ID,
				Status = status,
				Text = status.Status
			};
		}
	}
}
