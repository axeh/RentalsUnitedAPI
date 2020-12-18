using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("PaymentMethod")]
	public class PaymentMethodInfo
	{
		[XmlIgnore]
		public string PaymentMethod;

		[XmlAttribute]
		[OptionalField]
		public int ID;

		[XmlIgnore]
		public bool IDSpecified;

		[XmlAttribute]
		public int PaymentMethodID;

		[XmlText]
		public XmlNode[] CData
		{
			get
			{
				XmlDocument xmlDocument = new XmlDocument();
				return new XmlNode[1]
				{
					xmlDocument.CreateCDataSection(PaymentMethod)
				};
			}
			set
			{
				if (value == null)
				{
					if (string.IsNullOrEmpty(PaymentMethod))
					{
						return;
					}
					if (value.Length != 1)
					{
						throw new InvalidOperationException($"Invalid array length {value.Length}");
					}
				}
				PaymentMethod = value[0].Value;
			}
		}
	}
}
