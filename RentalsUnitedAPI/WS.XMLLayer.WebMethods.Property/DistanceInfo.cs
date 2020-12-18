using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Distance")]
	public class DistanceInfo
	{
		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecified;

		public int DestinationID;

		[XmlIgnore]
		public string Description;

		public int DistanceUnitID;

		public decimal DistanceValue;

		[XmlIgnore]
		public string DistanceUnits;
	}
}
