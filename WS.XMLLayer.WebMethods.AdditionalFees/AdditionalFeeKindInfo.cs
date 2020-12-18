using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	public class AdditionalFeeKindInfo
	{
		[XmlIgnore]
		public static readonly ReadOnlyCollection<AdditionalFeeKindInfo> PossibleValues = new ReadOnlyCollection<AdditionalFeeKindInfo>(new AdditionalFeeKindInfo[2]
		{
			new AdditionalFeeKindInfo
			{
				ID = 1,
				Description = "Tax - a kind representing generic tax value"
			},
			new AdditionalFeeKindInfo
			{
				ID = 2,
				Description = "Fee - a kind representing generic fee"
			}
		});

		[XmlText]
		public string Description;

		[XmlAttribute]
		public int ID;
	}
}
