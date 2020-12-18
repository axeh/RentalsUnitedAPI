using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Property")]
	public class PropertyInfoForCRM
	{
		public int ApartmentId
		{
			get;
			set;
		}

		public string ApartmentName
		{
			get;
			set;
		}

		public string Latitude
		{
			get;
			set;
		}

		public string Longitude
		{
			get;
			set;
		}

		public int CanSleepMax
		{
			get;
			set;
		}

		[XmlElement(ElementName = "OwnerID")]
		public int? LandlordID
		{
			get;
			set;
		}

		[XmlElement(ElementName = "LocationID")]
		public int? DetailedLocationID
		{
			get;
			set;
		}

		public List<ImageInfo> Images
		{
			get;
			set;
		}
	}
}
