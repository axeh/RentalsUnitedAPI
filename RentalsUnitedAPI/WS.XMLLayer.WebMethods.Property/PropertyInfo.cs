using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("Property")]
	public class PropertyInfo
	{
		[XmlElement(IsNullable = false)]
		public PUIDInfo PUID;

		[XmlIgnore]
		public bool PUIDSpecified;

		public IDInfo ID;

		public string Name;

		public int OwnerID;

		public DetailedLocationIDInfo DetailedLocationID;

		public LastModInfo LastMod;

		[XmlElement(IsNullable = false)]
		public DateCreatedInfo DateCreated;

		[Obsolete]
		public bool IMAP;

		[Obsolete]
		public bool IMU;

		public int UserID;

		[OptionalField]
		public string Advertiser;

		public int groupID;

		[XmlIgnore]
		public bool groupIDSpecified;

		public DateTime? ConnectDate;

		[XmlIgnore]
		public bool ConnectDateSpecified;

		[XmlIgnore]
		public string Username
		{
			get;
			set;
		}

		[OnSerializing]
		private void CheckAdvertiser(StreamingContext sc)
		{
			if (Advertiser != null && Advertiser.Trim() != string.Empty)
			{
				Advertiser = null;
			}
		}
	}
}
