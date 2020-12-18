using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("CancellationPolicy")]
	public class CancellationPolicyInfo : IEquatable<CancellationPolicyInfo>
	{
		[XmlAttribute]
		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecfied;

		[XmlText]
		public decimal CancellationPolicy;

		[XmlAttribute]
		public int ValidFrom;

		[XmlAttribute]
		public int ValidTo;

		public bool Equals(CancellationPolicyInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (ValidFrom == other.ValidFrom)
			{
				return ValidTo == other.ValidTo;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (obj.GetType() == GetType())
			{
				return Equals((CancellationPolicyInfo)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (ValidFrom * 397) ^ ValidTo;
		}
	}
}
