using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class AdditionalFeeTypeInfo
	{
		[XmlIgnore]
		public static readonly ReadOnlyCollection<AdditionalFeeTypeInfo> PossibleValues = new ReadOnlyCollection<AdditionalFeeTypeInfo>(new AdditionalFeeTypeInfo[42]
		{
			new AdditionalFeeTypeInfo
			{
				ID = 1,
				Description = "local tax"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 2,
				Description = "VAT"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 3,
				Description = "tourist tax"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 4,
				Description = "goods and services tax"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 5,
				Description = "city tax"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 6,
				Description = "Towels fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 7,
				Description = "Electricity fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 8,
				Description = "Bed linen fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 9,
				Description = "Gas fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 10,
				Description = "Oil fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 11,
				Description = "Wood fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 12,
				Description = "Water usage fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 13,
				Description = "Transfer fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 14,
				Description = "Linen package fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 15,
				Description = "Heating fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 16,
				Description = "Air conditioning fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 17,
				Description = "Kitchen linen fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 18,
				Description = "Housekeeping fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 19,
				Description = "Airport shuttle fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 20,
				Description = "Shuttle boat fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 21,
				Description = "Sea plane fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 22,
				Description = "Ski pass"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 23,
				Description = "Wristband fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 24,
				Description = "Visa support fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 25,
				Description = "Water park fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 26,
				Description = "Club card fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 27,
				Description = "Conservation fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 28,
				Description = "Credit card fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 29,
				Description = "Pet fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 30,
				Description = "Internet fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 0,
				Description = "unknown"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 31,
				Description = "Parking fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 32,
				Description = "Insurance"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 33,
				Description = "Service fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 34,
				Description = "Resort fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 35,
				Description = "Booking fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 36,
				Description = "Tourism fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 37,
				Description = "Destination fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 38,
				Description = "Extra bed fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 39,
				Description = "Environment fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 40,
				Description = "Children extra fee"
			},
			new AdditionalFeeTypeInfo
			{
				ID = 41,
				Description = "Cleaning fee"
			}
		});

		[XmlText]
		public string Description;

		[XmlAttribute]
		public int ID;
	}
}
