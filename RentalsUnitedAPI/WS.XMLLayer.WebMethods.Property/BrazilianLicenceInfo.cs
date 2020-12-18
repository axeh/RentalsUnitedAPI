using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("BrazilianLicenceInfo")]
	public class BrazilianLicenceInfo
	{
		public string CityHallInfoId;

		public bool ShouldSerializeCityHallInfoId()
		{
			return !string.IsNullOrEmpty(CityHallInfoId);
		}

		internal bool IsNotEmpty()
		{
			return ShouldSerializeCityHallInfoId();
		}
	}
}
