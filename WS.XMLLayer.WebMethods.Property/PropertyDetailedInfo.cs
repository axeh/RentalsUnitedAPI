using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;
using WS.XMLLayer.WebMethods.AdditionalFees;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("PropertyExtended")]
	public class PropertyDetailedInfo : PropertyInfo
	{
		private bool _isActive;

		private bool _isArchived;

		[XmlAttribute]
		public string Currency;

		[DefaultValue(-1)]
		public decimal CleaningPrice;

		public int Space;

		public int StandardGuests;

		public int CanSleepMax;

		public int PropertyTypeID;

		public int ObjectTypeID;

		public int NoOfUnits;

		public short Floor;

		public string Street;

		public string ZipCode;

		public string LicenseNumber;

		public LicenceInfo LicenceInfo;

		public CoordinatesInfo Coordinates;

		[XmlIgnore]
		public bool IsActiveSet;

		[XmlIgnore]
		public bool IsArchivedSet;

		[XmlIgnore]
		public List<DistanceInfo> DistancesList;

		[XmlIgnore]
		public List<CompositionRoomIDInfo> CompositionRoomsList;

		[XmlIgnore]
		public List<CompositionRoomAmenitiesInfo> CompositionRoomsAmenitiesList;

		[XmlIgnore]
		public List<AmenityInfo> AmenitiesList;

		[XmlIgnore]
		public List<ImageInfo> ImagesList;

		[XmlArray]
		public List<CaptionInfo> ImageCaptions;

		public ArrivalInstructionsInfo ArrivalInstructions;

		public CheckInOutInfo CheckInOut;

		[XmlIgnore]
		public List<PaymentMethodInfo> PaymentMethodsList;

		[XmlElement(ElementName = "Deposit")]
		public DepositInfo Deposit;

		[XmlIgnore]
		public List<CancellationPolicyInfo> CancellationPoliciesList;

		[XmlIgnore]
		public List<CancellationPolicyTextInfo> CancellationPoliciesTextList;

		[XmlIgnore]
		public List<DescriptionInfo> DescriptionsList;

		[XmlElement(ElementName = "SecurityDeposit")]
		public DepositInfo SecurityDeposit;

		[XmlIgnore]
		public int CityID;

		[XmlIgnore]
		public bool UserIDSpecified;

		[XmlIgnore]
		public List<AdditionalFeeInfo> AdditionalFeesList;

		public int? PreparationTimeBeforeArrival;

		public const string DefaultName = "-- default name --";

		public const int DefaultObjectTypeId = -1000;

		public const int DefaultNoOfUnits = -1000;

		public const int DefaultPropertyTypeId = -1000;

		public const int DefaultCanSleepMax = -1000;

		public const int DefaultFloor = -1000;

		public const int DefaultSpace = -1000;

		public const string DefaultStreet = "-- default street --";

		public const string DefaultZipCode = "-- default zip code --";

		public const int DefaultStandardGuests = -1000;

		public const decimal DefaultCleaningPrice = -1m;

		public int? NumberOfStars;

		public bool IsActive
		{
			get
			{
				return _isActive;
			}
			set
			{
				_isActive = value;
				IsActiveSet = true;
			}
		}

		public bool IsArchived
		{
			get
			{
				return _isArchived;
			}
			set
			{
				_isArchived = value;
				IsArchivedSet = true;
			}
		}

		[XmlArray]
		public DistanceInfo[] Distances
		{
			get
			{
				return DistancesList?.ToArray();
			}
			set
			{
				DistancesList = value?.ToList();
			}
		}

		[XmlArray]
		public CompositionRoomIDInfo[] CompositionRooms
		{
			get
			{
				return CompositionRoomsList?.ToArray();
			}
			set
			{
				CompositionRoomsList = value?.ToList();
			}
		}

		[XmlArray]
		public CompositionRoomAmenitiesInfo[] CompositionRoomsAmenities
		{
			get
			{
				return CompositionRoomsAmenitiesList?.ToArray();
			}
			set
			{
				CompositionRoomsAmenitiesList = value?.ToList();
			}
		}

		[XmlArray]
		public AmenityInfo[] Amenities
		{
			get
			{
				return AmenitiesList?.ToArray();
			}
			set
			{
				AmenitiesList = value?.ToList();
			}
		}

		[XmlArray]
		public ImageInfo[] Images
		{
			get
			{
				return ImagesList?.ToArray();
			}
			set
			{
				ImagesList = value?.ToList();
			}
		}

		[XmlArray]
		public PaymentMethodInfo[] PaymentMethods
		{
			get
			{
				return PaymentMethodsList?.ToArray();
			}
			set
			{
				PaymentMethodsList = value?.ToList();
			}
		}

		[XmlArray]
		public CancellationPolicyInfo[] CancellationPolicies
		{
			get
			{
				return CancellationPoliciesList?.ToArray();
			}
			set
			{
				CancellationPoliciesList = value?.ToList();
			}
		}

		[XmlArray]
		public CancellationPolicyTextInfo[] CancellationPoliciesText
		{
			get
			{
				return CancellationPoliciesTextList?.ToArray();
			}
			set
			{
				CancellationPoliciesTextList = value?.ToList();
			}
		}

		[XmlArray]
		public DescriptionInfo[] Descriptions
		{
			get
			{
				return DescriptionsList?.ToArray();
			}
			set
			{
				DescriptionsList = value?.ToList();
			}
		}

		[XmlArray]
		public AdditionalFeeInfo[] AdditionalFees
		{
			get
			{
				return AdditionalFeesList?.ToArray();
			}
			set
			{
				AdditionalFeesList = value?.ToList();
			}
		}

		public PropertyDetailedInfo()
		{
			Name = "-- default name --";
			ObjectTypeID = -1000;
			NoOfUnits = -1000;
			PropertyTypeID = -1000;
			CanSleepMax = -1000;
			Floor = -1000;
			Space = -1000;
			Street = "-- default street --";
			DetailedLocationID = null;
			ZipCode = "-- default zip code --";
			Coordinates = null;
			DistancesList = null;
			CompositionRoomsList = null;
			CompositionRoomsAmenitiesList = null;
			AmenitiesList = null;
			DescriptionsList = null;
			ImagesList = null;
			StandardGuests = -1000;
			ArrivalInstructions = new ArrivalInstructionsInfo();
			AdditionalFeesList = null;
			Deposit = null;
			SecurityDeposit = null;
			PaymentMethodsList = null;
			CleaningPrice = -1m;
			CancellationPoliciesList = null;
			CancellationPoliciesTextList = null;
		}

		public void RemoveDefaultValues()
		{
			Name = ((Name == "-- default name --") ? null : Name);
			ObjectTypeID = ((ObjectTypeID != -1000) ? ObjectTypeID : 0);
			NoOfUnits = ((NoOfUnits != -1000) ? NoOfUnits : 0);
			PropertyTypeID = ((PropertyTypeID != -1000) ? PropertyTypeID : 0);
			CanSleepMax = ((CanSleepMax != -1000) ? CanSleepMax : 0);
			Floor = (short)((Floor != -1000) ? Floor : 0);
			Space = ((Space != -1000) ? Space : 0);
			Street = ((Street == "-- default street --") ? null : Street);
			ZipCode = ((ZipCode == "-- default zip code --") ? null : ZipCode);
			StandardGuests = ((StandardGuests != -1000) ? StandardGuests : 0);
			ArrivalInstructions.DaysBeforeArrival = ((ArrivalInstructions.DaysBeforeArrival != -1000) ? ArrivalInstructions.DaysBeforeArrival : 0);
			ArrivalInstructions.Email = ((ArrivalInstructions.Email == "-- default email --") ? null : ArrivalInstructions.Email);
			ArrivalInstructions.Landlord = ((ArrivalInstructions.Landlord == "-- default landlord --") ? null : ArrivalInstructions.Landlord);
			ArrivalInstructions.Phone = ((ArrivalInstructions.Phone == "-- default phone --") ? null : ArrivalInstructions.Phone);
			if (CheckInOut != null)
			{
				CheckInOut.Place = ((CheckInOut.Place == "-- default place --") ? null : CheckInOut.Place);
			}
			CleaningPrice = ((CleaningPrice == -1m) ? 0m : CleaningPrice);
		}

		public bool ShouldSerializePreparationTimeBeforeArrival()
		{
			return PreparationTimeBeforeArrival.HasValue;
		}

		public bool ShouldSerializeNumberOfStars()
		{
			return NumberOfStars.HasValue;
		}
	}
}
