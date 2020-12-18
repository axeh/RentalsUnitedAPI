using System.Collections.Generic;

namespace WS.XMLLayer.WebMethods.Countries
{
	public class Pull_ListCountries_RS : BaseResponse
	{
		public List<CountryInfo> Countries
		{
			get;
			set;
		}
	}
}
