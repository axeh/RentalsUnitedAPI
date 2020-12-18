using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	public class Push_PutProperty_RQ : BaseRequest
	{
		public PropertyDetailedInfo Property;

		[XmlIgnore]
		public int? XmlWebServiceAccountId;

		[XmlElement("PMSID")]
		public string PMSID
		{
			get
			{
				if (!XmlWebServiceAccountId.HasValue)
				{
					return null;
				}
				return XmlWebServiceAccountId.ToString();
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					XmlWebServiceAccountId = null;
					return;
				}
				int result = 0;
				int.TryParse(value, out result);
				XmlWebServiceAccountId = result;
			}
		}

		[XmlElement("UserAccountId")]
		public string UserAccountId
		{
			get
			{
				if (!XmlWebServiceAccountId.HasValue)
				{
					return null;
				}
				return XmlWebServiceAccountId.ToString();
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					XmlWebServiceAccountId = null;
					return;
				}
				int result = 0;
				int.TryParse(value, out result);
				XmlWebServiceAccountId = result;
			}
		}

		public override void ValidateManadatoryElements()
		{
			List<string> list = new List<string>();
			if (Property == null)
			{
				list.Add("Property");
			}
			else
			{
				if (!Property.IsActiveSet)
				{
					list.Add("IsActive");
				}
				if (!Property.IsArchivedSet)
				{
					list.Add("IsArchived");
				}
			}
			string text = string.Join(", ", list);
			if (text.Length > 0)
			{
				throw new XMLLayerException(StatusInfoCode.MissingMandatoryElement, text);
			}
		}
	}
}
