using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.AdditionalFees
{
	[XmlType("AdditionalFee")]
	public class AdditionalFeeInfo
	{
		private sealed class AdditionalFeeInfoEqualityComparer : IEqualityComparer<AdditionalFeeInfo>
		{
			public bool Equals(AdditionalFeeInfo x, AdditionalFeeInfo y)
			{
				if (x == y)
				{
					return true;
				}
				if (x == null)
				{
					return false;
				}
				if (y == null)
				{
					return false;
				}
				if (x.GetType() != y.GetType())
				{
					return false;
				}
				if (x.Value == y.Value && x.Order == y.Order && x.DiscriminatorID == y.DiscriminatorID && x.KindID == y.KindID && string.Equals(x.Name, y.Name) && x.Optional == y.Optional && x.Refundable == y.Refundable)
				{
					return x.FeeTaxType == y.FeeTaxType;
				}
				return false;
			}

			public int GetHashCode(AdditionalFeeInfo obj)
			{
				return (((((((((((((((obj.Value.GetHashCode() * 397) ^ obj.Order) * 397) ^ obj.FeeTaxType) * 397) ^ obj.DiscriminatorID) * 397) ^ obj.KindID) * 397) ^ (obj.Name?.GetHashCode() ?? 0)) * 397) ^ obj.Optional.GetHashCode()) * 397) ^ obj.Refundable.GetHashCode()) * 397) ^ obj.CollectTime;
			}
		}

		public decimal Value
		{
			get;
			set;
		}

		[XmlAttribute]
		public int Order
		{
			get;
			set;
		}

		[XmlAttribute]
		public int DiscriminatorID
		{
			get;
			set;
		}

		[XmlAttribute]
		public int KindID
		{
			get;
			set;
		}

		[XmlAttribute]
		public string Name
		{
			get;
			set;
		}

		[XmlAttribute]
		public bool Optional
		{
			get;
			set;
		}

		[XmlAttribute]
		public bool Refundable
		{
			get;
			set;
		}

		[XmlAttribute]
		public int FeeTaxType
		{
			get;
			set;
		}

		[XmlAttribute]
		public int CollectTime
		{
			get;
			set;
		}

		[XmlIgnore]
		public bool IsPercent
		{
			get
			{
				if (DiscriminatorID != 4 && DiscriminatorID != 3 && DiscriminatorID != 13)
				{
					return DiscriminatorID == 14;
				}
				return true;
			}
		}

		public static IEqualityComparer<AdditionalFeeInfo> AdditionalFeeComparer
		{
			get;
		} = new AdditionalFeeInfoEqualityComparer();


		public AdditionalFeeInfo()
		{
			CollectTime = 1;
		}

		public bool IsPercentage()
		{
			if (DiscriminatorID != 3 && DiscriminatorID != 4)
			{
				return DiscriminatorID == 13;
			}
			return true;
		}
	}
}
