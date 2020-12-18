using System.ComponentModel;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	public class CustomerInfo
	{
		public string Name
		{
			get;
			set;
		}

		public string SurName
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public string MobilePhone
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public string SkypeID
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public string Address
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public string ZipCode
		{
			get;
			set;
		}

		[XmlElement(IsNullable = false)]
		public CountryIDInfo CountryID
		{
			get;
			set;
		}

		public int LanguageID
		{
			get;
			set;
		}

		[XmlIgnore]
		public bool LanguageIDSpecified
		{
			get;
			set;
		}

		[XmlIgnore]
		public string Comments
		{
			get;
			set;
		}

		public string Passport
		{
			get;
			set;
		}

		[XmlIgnore]
		public string State
		{
			get;
			set;
		}

		[DefaultValue(0)]
		public long MessagingContactId
		{
			get;
			set;
		}

		public CustomerInfo()
		{
			LanguageIDSpecified = false;
		}
	}
}
