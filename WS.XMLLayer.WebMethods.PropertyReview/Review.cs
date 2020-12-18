using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyReview
{
	public class Review
	{
		[XmlAttribute]
		public int ReviewID;

		[XmlIgnore]
		public bool ReviewIDSpecified;

		public string FirstName;

		public string LastName;

		public string DisplayName;

		public string Email;

		public byte Rating;

		public DateTime ArrivalDate;

		public DateTime Submitted;

		[XmlArrayItem("Text")]
		public List<ReviewTranslation> Texts;
	}
}
