using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("JapaneseLicenceInfo")]
	public class JapaneseLicenceInfo
	{
		public string CityAndWard;

		public string Prefecture;

		public JapaneseLicenceInfoLicenceType? LicenceType;

		public JapaneseLicenceInfoTypeOfDocument? TypeOfDocument;

		public JapaneseLicenceInfoRegistration Registration;

		public JapaneseLicenceInfoExemption Exemption;

		public bool ShouldSerializeLicenceType()
		{
			return LicenceType.HasValue;
		}

		public bool ShouldSerializeTypeOfDocument()
		{
			return TypeOfDocument.HasValue;
		}

		public bool ShouldSerializeRegistration()
		{
			if (Registration != null)
			{
				return Registration.IsNotEmpty();
			}
			return false;
		}

		public bool ShouldSerializeExemption()
		{
			if (Exemption != null)
			{
				return Exemption.IsNotEmpty();
			}
			return false;
		}

		public bool ShouldSerializeCityAndWard()
		{
			return !string.IsNullOrWhiteSpace(CityAndWard);
		}

		public bool ShouldSerializePrefecture()
		{
			return !string.IsNullOrWhiteSpace(Prefecture);
		}

		internal bool IsNotEmpty()
		{
			if (!ShouldSerializeLicenceType() && !ShouldSerializeTypeOfDocument() && !ShouldSerializeRegistration() && !ShouldSerializeExemption() && !ShouldSerializeCityAndWard())
			{
				return ShouldSerializePrefecture();
			}
			return true;
		}
	}
}
