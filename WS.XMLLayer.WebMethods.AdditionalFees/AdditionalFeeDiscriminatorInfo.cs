using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class AdditionalFeeDiscriminatorInfo
	{
		[XmlIgnore]
		public static readonly ReadOnlyCollection<AdditionalFeeDiscriminatorInfo> PossibleValues = new ReadOnlyCollection<AdditionalFeeDiscriminatorInfo>(new AdditionalFeeDiscriminatorInfo[14]
		{
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 1,
				Description = "FlatPerStay - a fixed value will be added once per whole stay. Value=10.05 means 10.05 EUR/USD or other currency will be added as additional fee."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 2,
				Description = "FixedPerDay - a fixed value will be added for each day of stay. Value=10.05 means 10.05 EUR/USD or other currency will be added as additional fee."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 3,
				Description = "IndependentPercentage - a percentage of total value will be added independently at the end of calculations. Value=0.0123 means 1.23% additional fee will be added."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 4,
				Description = "CumulativePercentage - a percentage of total value which will be added immediately and will take part in further calculation. Value=0.0123 means 1.23% additional fee will be added."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 5,
				Description = "FixedAmountPerPerson - a fixed value will be added for whole stay for each person."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 6,
				Description = "FixedAmountPerPersonPerDay - a fixed value will be added for each day of stay for each person."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 7,
				Description = "FixedAmountPerPersonPerWeek - a fixed value will be added for every week commenced, for each person."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 8,
				Description = "FixedAmountPerWeek - a fixed value will be added for every week commenced."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 9,
				Description = "VariableAmountByConsumption - the value of the fee depends on consumption."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 10,
				Description = "VariableAmountByUse - the value of the fee depends on use."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 11,
				Description = "FixedAmountPerSet - the value of the fee depends on number of sets."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 12,
				Description = "FixedAmountPerSetPerWeek - the value of the fee depends on number of sets, for every week commenced."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 13,
				Description = "IndependentPercentagePerDay - a percentage of total value for each day of stay will be added independently at the end of calculations."
			},
			new AdditionalFeeDiscriminatorInfo
			{
				ID = 14,
				Description = "IndependentPercentagePerPerson - a percentage of total value for each person will be added independently at the end of calculations."
			}
		});

		[XmlText]
		public string Description;

		[XmlAttribute]
		public int ID;
	}
}
