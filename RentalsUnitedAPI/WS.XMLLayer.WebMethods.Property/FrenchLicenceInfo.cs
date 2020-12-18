using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("FrenchLicenceInfo")]
	public class FrenchLicenceInfo
	{
		public bool? IsRegisteredAtTradeCommercialRegister;

		public bool? DeclaresRevenuesAsProfessionalForDirectTaxPurposes;

		public int? TypeOfResidence;

		public int? CityTaxCategory;

		public PropertyTypeForTaxPurposes? PropertyTypeForTaxPurposes;

		public bool ShouldSerializeIsRegisteredAtTradeCommercialRegister()
		{
			return IsRegisteredAtTradeCommercialRegister.HasValue;
		}

		public bool ShouldSerializeDeclaresRevenuesAsProfessionalForDirectTaxPurposes()
		{
			return DeclaresRevenuesAsProfessionalForDirectTaxPurposes.HasValue;
		}

		internal bool IsNotEmpty()
		{
			if (!ShouldSerializeIsRegisteredAtTradeCommercialRegister() && !ShouldSerializeDeclaresRevenuesAsProfessionalForDirectTaxPurposes() && !ShouldSerializeTypeOfResidence() && !ShouldSerializeCityTaxCategory())
			{
				return ShouldSerializePropertyTypeForTaxPurposes();
			}
			return true;
		}

		public bool ShouldSerializeTypeOfResidence()
		{
			return TypeOfResidence.HasValue;
		}

		public bool ShouldSerializeCityTaxCategory()
		{
			return CityTaxCategory.HasValue;
		}

		public bool ShouldSerializePropertyTypeForTaxPurposes()
		{
			return PropertyTypeForTaxPurposes.HasValue;
		}
	}
}
