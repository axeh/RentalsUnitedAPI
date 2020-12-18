using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("LicenceInfo")]
	public class LicenceInfo
	{
		public string LicenceNumber;

		public bool? IsVATRegistered;

		public bool? IsManagedByPrivatePerson;

		public FrenchLicenceInfo FrenchLicenceInfo;

		[XmlElement(ElementName = "IssueDate", DataType = "date")]
		public DateTime? IssueDate;

		[XmlElement(ElementName = "ExpirationDate", DataType = "date")]
		public DateTime? ExpirationDate;

		public bool? IsExempt;

		public LicenceExemptionReason? ExemptionReason;

		public BrazilianLicenceInfo BrazilianLicenceInfo;

		public JapaneseLicenceInfo JapaneseLicenceInfo;

		public bool? IsManagedByOwner;

		public TasmanianLicenceInfo TasmanianLicenceInfo;

		public bool ShouldSerializeIsVATRegistered()
		{
			return IsVATRegistered.HasValue;
		}

		public bool ShouldSerializeIsManagedByPrivatePerson()
		{
			return IsManagedByPrivatePerson.HasValue;
		}

		public bool ShouldSerializeFrenchLicenceInfo()
		{
			return FrenchLicenceInfo?.IsNotEmpty() ?? false;
		}

		public bool ShouldSerializeIssueDate()
		{
			return IssueDate.HasValue;
		}

		public bool ShouldSerializeExpirationDate()
		{
			return ExpirationDate.HasValue;
		}

		public bool ShouldSerializeIsExempt()
		{
			return IsExempt.HasValue;
		}

		public bool ShouldSerializeExemptionReason()
		{
			return ExemptionReason.HasValue;
		}

		public bool ShouldSerializeBrazilianLicenceInfo()
		{
			return BrazilianLicenceInfo?.IsNotEmpty() ?? false;
		}

		public bool ShouldSerializeJapaneseLicenceInfo()
		{
			return JapaneseLicenceInfo?.IsNotEmpty() ?? false;
		}

		public bool ShouldSerializeIsManagedByOwner()
		{
			return IsManagedByOwner.HasValue;
		}

		public bool ShouldSerializeTasmanianLicenceInfo()
		{
			return TasmanianLicenceInfo?.IsNotEmpty() ?? false;
		}
	}
}
