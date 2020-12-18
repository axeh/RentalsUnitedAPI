using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("TasmanianLicenceInfo")]
	public class TasmanianLicenceInfo
	{
		public TasmanianLicenceInfoTypeOfResidence? TypeOfResidence;

		public bool ShouldSerializeTasmanianLicenceInfoTypeOfResidence()
		{
			return TypeOfResidence.HasValue;
		}

		internal bool IsNotEmpty()
		{
			return ShouldSerializeTasmanianLicenceInfoTypeOfResidence();
		}
	}
}
