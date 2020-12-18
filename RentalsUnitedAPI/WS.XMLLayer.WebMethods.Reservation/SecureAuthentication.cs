using System;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Reservation
{
	[XmlType("SecureAuthentication")]
	public class SecureAuthentication
	{
		public string CAVV;

		public string ECI;

		public string XID;

		public Guid DsTransID;

		public string ThreeDSVersion;

		public SecureException? ExceptionType;
	}
}
