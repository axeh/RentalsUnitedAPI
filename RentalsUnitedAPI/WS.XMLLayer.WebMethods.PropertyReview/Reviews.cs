using System.Collections.Generic;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.PropertyReview
{
	public class Reviews
	{
		[XmlAttribute]
		public int PropertyID;

		[XmlElement("Review")]
		public List<Review> ReviewList
		{
			get;
			set;
		}
	}
}
