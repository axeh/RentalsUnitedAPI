using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods
{
	public class StatusInfo
	{
		[XmlText]
		public string Status;

		[XmlAttribute]
		public int ID;

		[XmlIgnore]
		private static readonly Dictionary<int, StatusInfo> Statuses = new Dictionary<int, StatusInfo>
		{
			{
				-6,
				new StatusInfo(-6, "This request was rate limited. Maximum number of requests allowed for this API method with specified parameters is {0} per {1} sliding window. You have reached this limit.")
			},
			{
				-5,
				new StatusInfo(-5, "This request was rate limited. Maximum concurrent requests allowed for this API method with specified parameters is {0}. You have reached this limit.")
			},
			{
				-4,
				new StatusInfo(-4, "Incorrect login or password")
			},
			{
				-3,
				new StatusInfo(-3, "Invalid request. {0}")
			},
			{
				-2,
				new StatusInfo(-2, "This request cannot be processed. {0}")
			},
			{
				-1,
				new StatusInfo(-1, "The XML contains not implemented method")
			},
			{
				0,
				new StatusInfo(0, "Success")
			},
			{
				1,
				new StatusInfo(1, "Property is not available for a given dates")
			},
			{
				2,
				new StatusInfo(StatusInfoCode.NothingAvailableForGivenDates, "Nothing available for a given dates")
			},
			{
				3,
				new StatusInfo(StatusInfoCode.PropertyHasNoPriceSettingsForGivenDates, "Property has no price settings for a given dates")
			},
			{
				4,
				new StatusInfo(4, "Wrong destination id:{0}")
			},
			{
				5,
				new StatusInfo(5, "Wrong distance unit id:{0}")
			},
			{
				6,
				new StatusInfo(6, "Wrong composition room id:{0}")
			},
			{
				7,
				new StatusInfo(7, "Wrong amenity id:{0}")
			},
			{
				8,
				new StatusInfo(8, "Wrong arrival instructions")
			},
			{
				9,
				new StatusInfo(9, "Could not insert late arrival fee, From:{0} To:{1} Fee:{2}")
			},
			{
				10,
				new StatusInfo(10, "Could not insert early departure fee, From:{0} To:{1} Fee:{2}")
			},
			{
				11,
				new StatusInfo(11, "Wrong payment method id:{0}")
			},
			{
				12,
				new StatusInfo(12, "Wrong deposit type id:{0}")
			},
			{
				13,
				new StatusInfo(13, "Cancallation policies overlaps")
			},
			{
				14,
				new StatusInfo(14, "Owner does not exist")
			},
			{
				15,
				new StatusInfo(15, "Apartment name ({0}) already exist in database.")
			},
			{
				16,
				new StatusInfo(16, "You already defined apartment with PUID:{0}")
			},
			{
				17,
				new StatusInfo(17, "Unexpected error, contact IT or try again")
			},
			{
				18,
				new StatusInfo(18, "Property with given ID does not exist.")
			},
			{
				19,
				new StatusInfo(19, "Dates mishmash")
			},
			{
				20,
				new StatusInfo(20, "Past dates")
			},
			{
				21,
				new StatusInfo(21, "Weird block dates for property: {0} - {1} - {2}. Whole block is {3} - {4}")
			},
			{
				22,
				new StatusInfo(22, "We have confirmed reservation for those dates. Please cancel the reservation instead of marking the dates as available.")
			},
			{
				23,
				new StatusInfo(23, "Wrong ImageTypeID:{0}")
			},
			{
				24,
				new StatusInfo(24, "Your are not the owner of the apartment.")
			},
			{
				25,
				new StatusInfo(25, "The value of \"Bigger\" must be smaller than the value of \"Smaller\".")
			},
			{
				26,
				new StatusInfo(26, "Warning! Look at Notifs collection.")
			},
			{
				27,
				new StatusInfo(27, "DaysToArrivalFrom and DaysToArrivalTo requires positive values.")
			},
			{
				28,
				new StatusInfo(28, "Reservation does not exist.")
			},
			{
				29,
				new StatusInfo(29, "Requested stay, cost details do not match with property on reservation on hold.")
			},
			{
				30,
				new StatusInfo(30, "Element ignored because of other errors.")
			},
			{
				31,
				new StatusInfo(31, "Error occured. All changes rolled back.")
			},
			{
				32,
				new StatusInfo(32, "Bigger and Smaller requires positive values.")
			},
			{
				33,
				new StatusInfo(33, "Smaller is smaller than Bigger.")
			},
			{
				34,
				new StatusInfo(34, "RUPrice is not valid. Correct price is:{0}")
			},
			{
				35,
				new StatusInfo(35, "AlreadyPaid is bigger than ClientPrice.")
			},
			{
				36,
				new StatusInfo(36, "Wrong DetailedLocationID. City or district precision is required.")
			},
			{
				37,
				new StatusInfo(37, "Property name is too long (max 150).")
			},
			{
				38,
				new StatusInfo(38, "Property has missing data and cannot be offered.")
			},
			{
				39,
				new StatusInfo(39, "Location does not exist.")
			},
			{
				40,
				new StatusInfo(40, "You cannot define discounts before the prices. The property has missing prices in given dates.")
			},
			{
				41,
				new StatusInfo(41, "The reservation was created by the other user.")
			},
			{
				42,
				new StatusInfo(42, "The reservation is expired.")
			},
			{
				43,
				new StatusInfo(43, "You cannot confirm this reservation. It's broken.")
			},
			{
				44,
				new StatusInfo(44, "The apartments are not in the same city.")
			},
			{
				45,
				new StatusInfo(45, "Data validation error.")
			},
			{
				46,
				new StatusInfo(46, "The property is not active. PropertyID:{0}")
			},
			{
				47,
				new StatusInfo(47, "Property is not available for a given dates. PropertyID:{0}")
			},
			{
				48,
				new StatusInfo(48, "The reservation is not on Put On Hold status.")
			},
			{
				49,
				new StatusInfo(49, "CountryID does not exist.")
			},
			{
				50,
				new StatusInfo(50, "Guest name is required.")
			},
			{
				51,
				new StatusInfo(51, "Guest surname is required.")
			},
			{
				52,
				new StatusInfo(52, "Guest email is required.")
			},
			{
				53,
				new StatusInfo(53, "This method is deprecated. Use Push_PutConfirmedReservationMulti_RS")
			},
			{
				54,
				new StatusInfo(54, "This method is deprecated. Use Push_PutPropertiesOnHold_RQ")
			},
			{
				55,
				new StatusInfo(55, "Negative values in price elements is not allowed.")
			},
			{
				56,
				new StatusInfo(StatusInfoCode.PropertyDoesNotExist, "Property does not exist.")
			},
			{
				57,
				new StatusInfo(57, "The request contains both types of composition definitions: composition and composition with amenities. Please use only one type.")
			},
			{
				58,
				new StatusInfo(58, "This amenity: {0} is not allowed in room type: {1}")
			},
			{
				59,
				new StatusInfo(59, "Positive value is required")
			},
			{
				60,
				new StatusInfo(60, "Duplicate value in LOSS element")
			},
			{
				61,
				new StatusInfo(61, "Duplicate value in EGPS element")
			},
			{
				62,
				new StatusInfo(62, "Missing Text or Image value.")
			},
			{
				63,
				new StatusInfo(63, "Wrong laguage id:{0}.")
			},
			{
				64,
				new StatusInfo(64, "DayOfWeek attribute must be between {0} and {1}.")
			},
			{
				65,
				new StatusInfo(65, "No permission to property {0}.")
			},
			{
				66,
				new StatusInfo(66, "Coordinates are invalid or missing.")
			},
			{
				67,
				new StatusInfo(67, "Duplicate value in LOSPS element")
			},
			{
				68,
				new StatusInfo(68, "NumberOfGuests in LOSP element has to be greather than 0")
			},
			{
				69,
				new StatusInfo(69, "Building does not exist")
			},
			{
				70,
				new StatusInfo(70, "Some properties not updated:{0}")
			},
			{
				71,
				new StatusInfo(71, "Wrong security deposit type id: {0}")
			},
			{
				72,
				new StatusInfo(72, "Discount value can't be lower than 0.")
			},
			{
				73,
				new StatusInfo(73, "At least one PropertyID element is required.")
			},
			{
				74,
				new StatusInfo(StatusInfoCode.DateFromHasToBeEarlierThanDateTo, "DateFrom has to be earlier than DateTo.")
			},
			{
				75,
				new StatusInfo(75, "DateFrom has to be earlier or equal to DateTo.")
			},
			{
				76,
				new StatusInfo(76, "StandardGuests must be smaller than CanSleepMax.")
			},
			{
				77,
				new StatusInfo(StatusInfoCode.NOPPositiveCalueRequired, "NOP: positive value required.")
			},
			{
				78,
				new StatusInfo(78, "Minimum stay is not valid (X nights).")
			},
			{
				79,
				new StatusInfo(StatusInfoCode.StayPeriodDoesntMatchWithMinimumStay, "Stay period doesn't match with minimum stay")
			},
			{
				80,
				new StatusInfo(80, "Cannot activate archived property")
			},
			{
				81,
				new StatusInfo(81, "You don't have permission to modify this owner")
			},
			{
				82,
				new StatusInfo(StatusInfoCode.ApartmentIsArchivedOrNLAOrNotActive, "Apartment is Archived or no longer available or not Active")
			},
			{
				83,
				new StatusInfo(83, "Mixed owners in the request. Contact IT.")
			},
			{
				84,
				new StatusInfo(84, "Too many properties in your request (max 100).")
			},
			{
				85,
				new StatusInfo(85, "Invalid time value. Allowed values 00:00 - 23:59")
			},
			{
				86,
				new StatusInfo(86, "Operation has reached the maximum limit of time. The results are not complete.")
			},
			{
				87,
				new StatusInfo(87, "Wrong page URL Type")
			},
			{
				88,
				new StatusInfo(88, "Wrong date format for parameter {0}")
			},
			{
				89,
				new StatusInfo(StatusInfoCode.StayPeriodDoesntMatchWithChangeover, "Stay period doesn't match with changeover")
			},
			{
				90,
				new StatusInfo(90, "Enqueued")
			},
			{
				91,
				new StatusInfo(91, "Not found")
			},
			{
				92,
				new StatusInfo(92, "Duplicate value in distances.")
			},
			{
				93,
				new StatusInfo(93, "Unauthorized")
			},
			{
				94,
				new StatusInfo(94, "Some of required fields were not filled.")
			},
			{
				95,
				new StatusInfo(95, "Email already exists.")
			},
			{
				96,
				new StatusInfo(96, "Password must be at least 8 characters long.")
			},
			{
				97,
				new StatusInfo(97, "Standard number of guests must be of positive value.")
			},
			{
				98,
				new StatusInfo(98, "Deposit amount can't exceed value of 214,748.3647")
			},
			{
				99,
				new StatusInfo(99, "Technical error - missing file")
			},
			{
				100,
				new StatusInfo(100, "Property description is required")
			},
			{
				101,
				new StatusInfo(101, "Pets not allowed")
			},
			{
				102,
				new StatusInfo(102, "Currency doesn't match with city currency")
			},
			{
				103,
				new StatusInfo(103, "Properties collection cannot be empty")
			},
			{
				104,
				new StatusInfo(104, "You need provide at least one value to modify stay.")
			},
			{
				105,
				new StatusInfo(105, "Some periods overlap. Periods must be separable.")
			},
			{
				106,
				new StatusInfo(106, "You can only modify stay in confirmed reservation.")
			},
			{
				107,
				new StatusInfo(107, "No reserved apartment found.")
			},
			{
				108,
				new StatusInfo(108, "Client Price cannot be negative")
			},
			{
				109,
				new StatusInfo(109, "Already Paid cannot be negative.")
			},
			{
				110,
				new StatusInfo(110, "Can not use OwnerID created by other users.")
			},
			{
				111,
				new StatusInfo(111, "Only property owner can add reviews.")
			},
			{
				112,
				new StatusInfo(112, "Review rating value must be between 0-5")
			},
			{
				113,
				new StatusInfo(113, "Submitted date must be later than arrival date")
			},
			{
				114,
				new StatusInfo(114, "Cannot remove confirmed reservation. Some periods ignored.")
			},
			{
				115,
				new StatusInfo(StatusInfoCode.MinStaysNotSatisfied, "MinStays not satisfied, collection cannot be empty.")
			},
			{
				116,
				new StatusInfo(116, "LocationID {0} is not proper city location.")
			},
			{
				117,
				new StatusInfo(117, "Only one description allowed per language.")
			},
			{
				118,
				new StatusInfo(118, "Max number of guests must be of positive value.")
			},
			{
				119,
				new StatusInfo(119, "Property name is not defined.")
			},
			{
				120,
				new StatusInfo(120, "Check-in / check-out details are incorrect.")
			},
			{
				121,
				new StatusInfo(121, "Reservation not mapped in PMS. Contact IT support with Rentals United ID and your PMS Reservation ID.")
			},
			{
				122,
				new StatusInfo(122, "Failed to modify reservation in PMS. Try again or contact IT support for more information.")
			},
			{
				123,
				new StatusInfo(123, "Failed to cancel reservation in PMS. Try again or contact IT support for more information.")
			},
			{
				124,
				new StatusInfo(124, "Failed to insert reservation in PMS. Try again or contact IT support for more information.")
			},
			{
				125,
				new StatusInfo(125, "Wrong quantity of amenities. It should be between 0 - 32767.")
			},
			{
				126,
				new StatusInfo(126, "Invalid URL.")
			},
			{
				127,
				new StatusInfo(StatusInfoCode.MissingMandatoryElement, "Missing mandatory element: {0}.")
			},
			{
				128,
				new StatusInfo(128, "Cancellation policy text cannot be empty.")
			},
			{
				129,
				new StatusInfo(129, "Only reservations for apartments from same city are allowed")
			},
			{
				130,
				new StatusInfo(130, "Cannot change apartment from city other than initial reservation. Cancel this reservation and create new one.")
			},
			{
				131,
				new StatusInfo(131, "Bad request.")
			},
			{
				132,
				new StatusInfo(132, "This functionality is forbidden for you.")
			},
			{
				133,
				new StatusInfo(133, "Too many images. Images limit is 100.")
			},
			{
				134,
				new StatusInfo(StatusInfoCode.InvalidCurrency, "Invalid currency.")
			},
			{
				135,
				new StatusInfo(StatusInfoCode.RequestRejectedByPartner, "Request rejected by partner.")
			},
			{
				136,
				new StatusInfo(136, "Customer info is required.")
			},
			{
				137,
				new StatusInfo(137, "PMSID is not valid.")
			},
			{
				138,
				new StatusInfo(138, "Provide a not empty PUID.")
			},
			{
				139,
				new StatusInfo(139, "Cannot create new property as archived.")
			},
			{
				140,
				new StatusInfo(140, "PropertyID : {0} cannot be archived / activated. The whole request was cancelled. Use Push_PutProperty_RQ instead.")
			},
			{
				141,
				new StatusInfo(141, "PUID already exists for another property.")
			},
			{
				142,
				new StatusInfo(142, "Property already has PMSID assigned. You cannot omit PMSID while update.")
			},
			{
				143,
				new StatusInfo(143, "Cannot archive this property. {0}")
			},
			{
				144,
				new StatusInfo(144, "Invalid Additional fees collection. {0}")
			},
			{
				145,
				new StatusInfo(145, "There are not enough units in this property.")
			},
			{
				146,
				new StatusInfo(146, "Multi unit functionality is disabled.")
			},
			{
				147,
				new StatusInfo(147, "Changeover is invalid. Use number 1, 2, 3 or 4.")
			},
			{
				148,
				new StatusInfo(148, "Number of units do not match with reservation on hold.")
			},
			{
				149,
				new StatusInfo(149, "Units must be a positive number")
			},
			{
				150,
				new StatusInfo(150, "Invalid invoice ID")
			},
			{
				151,
				new StatusInfo(151, "CancelUrl is missing")
			},
			{
				152,
				new StatusInfo(152, "ReturnUrl is missing")
			},
			{
				153,
				new StatusInfo(153, "PayPal transaction failed")
			},
			{
				154,
				new StatusInfo(154, "Single unit apartment cannot be converted to multi unit")
			},
			{
				155,
				new StatusInfo(155, "ResApaID has to be provided for multi unit properties")
			},
			{
				156,
				new StatusInfo(156, "ResApaID is not valid")
			},
			{
				157,
				new StatusInfo(157, "Card registration failed")
			},
			{
				158,
				new StatusInfo(158, "Request rejected. Check PMS synchronization settings")
			},
			{
				159,
				new StatusInfo(159, "Failed to insert reservation for property {0}({1}) to PMS. {2}")
			},
			{
				160,
				new StatusInfo(160, "The location and city already added to database")
			},
			{
				161,
				new StatusInfo(161, "You are not permitted to list this user's reservations")
			},
			{
				162,
				new StatusInfo(162, "Pass valid email")
			},
			{
				163,
				new StatusInfo(163, "Future dates")
			},
			{
				164,
				new StatusInfo(164, "Invalid date format")
			},
			{
				165,
				new StatusInfo(165, "You cannot archive a confirmed reservation. If this is a cancellation please cancel it first.")
			},
			{
				166,
				new StatusInfo(166, "Reservation is archived. Unarchive first before performing this operation.")
			},
			{
				167,
				new StatusInfo(167, "Reservation is for properties you are not the owner of")
			},
			{
				168,
				new StatusInfo(168, "Reservation is not canceled.")
			},
			{
				169,
				new StatusInfo(StatusInfoCode.CanNotProcessARequestBecauseApartmentIsConnectedToRMS, "Can not process a request because apartment is connected to RMS")
			},
			{
				170,
				new StatusInfo(170, "Invalid property type id")
			},
			{
				171,
				new StatusInfo(StatusInfoCode.InvalidAdditionalDataXml, "Invalid xml format in AdditionalData node")
			},
			{
				172,
				new StatusInfo(StatusInfoCode.PtbaNotSatisfied, "Preparation time before arrival is blocking requested stay")
			},
			{
				173,
				new StatusInfo(StatusInfoCode.LongStayNrOfNightsTrimmed, "Discount ignored or trimmed. Maximum length of discounted stay is {0} nights.")
			},
			{
				174,
				new StatusInfo(StatusInfoCode.InvalidFrenchTaxCategory, "Invalid field LicenceInfo/FrenchLicenceInfo/CityTaxCategory. Allowed values: 11-19")
			},
			{
				175,
				new StatusInfo(StatusInfoCode.InvalidFrenchResidenceType, "Invalid field LicenceInfo/FrenchLicenceInfo/TypeOfResidence. Allowed values: 1-3")
			},
			{
				176,
				new StatusInfo(StatusInfoCode.RequestConfirmationInExternalSystemFailed, "Request confirmation in external system failed")
			},
			{
				177,
				new StatusInfo(StatusInfoCode.PropertyNotConnectedToExternalSystem, "Property is not connected to external system")
			},
			{
				178,
				new StatusInfo(StatusInfoCode.CannotCancelSCReservationInRU, "This reservation was made in external system and cannot be cancelled in Rentals United. Please cancel it directly in the sales channel")
			},
			{
				179,
				new StatusInfo(StatusInfoCode.AdditionalFeeValueNotPositive, "Additional fee value must be greater or equal zero")
			},
			{
				180,
				new StatusInfo(StatusInfoCode.SeasonInfoCanNotContainsLOSPricesAndFullStayPrices, "LOS pricing and full stay pricing can not be defined in the same season")
			},
			{
				181,
				new StatusInfo(StatusInfoCode.NumberOfUnitsInMultiunitPropertyCanNotBeDecreased, "Number of units can not be decreased")
			},
			{
				182,
				new StatusInfo(StatusInfoCode.SeasonInfoCanNotContainsEGPSAndFullStayPrices, "EGPS (A collection of extra guests price settings depending on the number of extra guests) and full stay pricing can not be defined in the same season")
			},
			{
				183,
				new StatusInfo(StatusInfoCode.SeasonInfoCanNotContainsExtraAndFullStayPrices, "Extra (Extra fee for each guest above the standard number of guests) and full stay pricing can not be defined in the same season")
			},
			{
				184,
				new StatusInfo(StatusInfoCode.SeasonInfoWithFSPCanNotBeLongerThenOneDay, "Season with FSP can not be longer then one day")
			},
			{
				185,
				new StatusInfo(StatusInfoCode.SeasonInfoCanNotContainsFSPWithTheSameNrOfGuestsAndNights, "Season can not contains FSP with the same number of guests and number of nights")
			},
			{
				187,
				new StatusInfo(StatusInfoCode.MissingOwnerID, "Please provide a valid OwnerID. Keep in mind it is case sensitive.")
			},
			{
				188,
				new StatusInfo(StatusInfoCode.InvalidLanguageCaption, "Invalid Language ID in Image Caption")
			},
			{
				189,
				new StatusInfo(StatusInfoCode.InvalidLanguageDescription, "Invalid Lanugage ID in Description")
			},
			{
				190,
				new StatusInfo(StatusInfoCode.MissingImageReferenceID, "Found orphaned image caption. No image with identical reference ID {0}")
			},
			{
				192,
				new StatusInfo(StatusInfoCode.DuplicateDescriptionLanguageID, "Found descriptions with duplicate language ID.")
			},
			{
				191,
				new StatusInfo(StatusInfoCode.DuplicateCaptionLanguageID, "Found image captions with duplicate language ID")
			},
			{
				193,
				new StatusInfo(StatusInfoCode.InvalidImageTypeID, "Invalid ImageTypeID in Image collection")
			},
			{
				186,
				new StatusInfo(StatusInfoCode.FspSeasonInfoCanNotBeMixedWithPriceInfoWithPriceOnly, "Season can not be mixed with FSPSeason")
			},
			{
				194,
				new StatusInfo(StatusInfoCode.FSPRowsCanNotBeDefinedForTheSameDayWithTheSameNumberOfGuests, "FSPRows can not be defined for the same day with the same number of guests")
			},
			{
				195,
				new StatusInfo(StatusInfoCode.PricesWithSameNumberOfGuestsCanNotBeDefinedInOneFSPRow, "Prices with the same number of guests can not be defined in one FSPRow")
			},
			{
				196,
				new StatusInfo(StatusInfoCode.DefaultPriceHasToBePositiveValue, "DefaultPrice has to be positive value")
			},
			{
				197,
				new StatusInfo(StatusInfoCode.PriceInPricePerNightHasToBePositiveValue, "Price in PricePerNight has to be positive value")
			},
			{
				198,
				new StatusInfo(StatusInfoCode.FspRowPricePerNightNrOfNightsCanNotBeLongerThanRUMax, "Number of nights of PricePerNight in FspRow can not be longer than 30 days")
			},
			{
				199,
				new StatusInfo(StatusInfoCode.FSPRowDefaultPriceCanNotBeSpecifiedWithoutAnyFSPRows, "DefaultPrice can not be specified without specifying any FSPRows")
			},
			{
				200,
				new StatusInfo(StatusInfoCode.DateToCanNotBeInThePast, "DateTo cannot be in the past")
			},
			{
				201,
				new StatusInfo(StatusInfoCode.CantUseOwnerAndUsername, "Please use OwnerId or Username , cant use them both")
			}
		};

		[XmlIgnore]
		public static StatusInfo Success => GetStatus(0);

		[XmlIgnore]
		//[ScriptIgnore]
		public bool IsSuccess => ID == Success.ID;

		public StatusInfo()
		{
		}

		public StatusInfo(int id, string description)
		{
			ID = id;
			Status = description;
		}

		public StatusInfo(StatusInfoCode id, string description)
		{
			ID = (int)id;
			Status = description;
		}

		public static Dictionary<int, StatusInfo> GetStatuses()
		{
			return Statuses;
		}

		public static StatusInfo GetStatus(int i)
		{
			if (Statuses.ContainsKey(i))
			{
				return (StatusInfo)Statuses[i].MemberwiseClone();
			}
			return null;
		}

		public static StatusInfo GetStatus(StatusInfoCode statusInfoCode)
		{
			return GetStatus((int)statusInfoCode);
		}

		public string ReplaceValue(params object[] param)
		{
			return Status = string.Format(Status, param);
		}
	}
}
