using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using WS.XMLLayer.WebMethods.Reservation;

namespace WS.XMLLayer
{
	public static class XmlTools
	{
		private static Regex invalidCharsRegex = new Regex("[\0-\b\v\f\u000e-\u001f\u007f-\u0084\u0086-\u009f]", RegexOptions.Compiled);

		public static string SerializeObject<T>(T o, bool modify = true)
		{
			string text = "";
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			using (MemoryStream memoryStream = new MemoryStream())
			{
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.NewLineHandling = NewLineHandling.Entitize;
				xmlWriterSettings.Encoding = Encoding.UTF8;
				using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
				{
					XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
					xmlSerializerNamespaces.Add("", "");
					xmlSerializer.Serialize(xmlWriter, o, xmlSerializerNamespaces);
				}
				text = Encoding.UTF8.GetString(memoryStream.GetBuffer());
			}
			text = text.Substring(text.IndexOf(Convert.ToChar(60)));
			text = text.Substring(0, text.LastIndexOf(Convert.ToChar(62)) + 1);
			if (modify)
			{
				text = text.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
				text = Regex.Replace(text, "([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2})T([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2})(.[\\d]{3})?Z?", "$1 $2");
				text = invalidCharsRegex.Replace(text, string.Empty);
			}
			return text;
		}

		public static T DeserializeObject<T>(string xml, bool modify = true) where T : class
		{
			if (modify)
			{
				xml = xml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
				xml = xml.Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
				xml = Regex.Replace(xml, "\"([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2}) ([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2})Z?\"", "\"$1T$2\"");
				xml = Regex.Replace(xml, "[>]([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2}) ([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2})Z?[<]", ">$1T$2<");
				xml = invalidCharsRegex.Replace(xml, string.Empty);
			}
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			using (StringReader input = new StringReader(xml))
			{
				using (XmlTextReader xmlReader = new XmlTextReader(input))
				{
					return xmlSerializer.Deserialize(xmlReader) as T;
				}
			}
		}

		public static string SerializeObject(Type t, object o)
		{
			return SerializeObject(t, o, modify: true);
		}

		public static string SerializeObject(Type t, object o, bool modify, string additionalNameSpacePrefix = "", string additionalNameSpace = "", bool removeXmlns = true)
		{
			string text = "";
			XmlSerializer xmlSerializer = new XmlSerializer(t);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.CheckCharacters = false;
				xmlWriterSettings.NewLineHandling = NewLineHandling.Entitize;
				xmlWriterSettings.Encoding = Encoding.UTF8;
				using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
				{
					XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
					xmlSerializerNamespaces.Add(additionalNameSpacePrefix, additionalNameSpace);
					xmlSerializer.Serialize(xmlWriter, o, xmlSerializerNamespaces);
				}
				text = Encoding.UTF8.GetString(memoryStream.GetBuffer());
			}
			text = text.Substring(text.IndexOf(Convert.ToChar(60)));
			text = text.Substring(0, text.LastIndexOf(Convert.ToChar(62)) + 1);
			if (modify)
			{
				text = text.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
				text = Regex.Replace(text, "([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2})T([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2})(?:.[\\d]{3,7}(?:[\\+][\\d]{2}:[\\d]{2})?)?Z?", "$1 $2");
				text = invalidCharsRegex.Replace(text, string.Empty);
			}
			if (removeXmlns)
			{
				text = Regex.Replace(text, "xmlns=\".+?\"", "");
			}
			return text;
		}

		public static object DeserializeObject(Type t, string xml)
		{
			xml = xml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
			xml = xml.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", "");
			xml = xml.Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
			xml = Regex.Replace(xml, "\"([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2}) ([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2}(?:\\.[\\d]{1,3})?)Z?\"", "\"$1T$2\"");
			xml = Regex.Replace(xml, "[>]([\\d]{4,4}-[\\d]{2,2}-[\\d]{2,2}) ([\\d]{2,2}:[\\d]{2,2}:[\\d]{2,2}(?:\\.[\\d]{1,3})?)Z?[<]", ">$1T$2<");
			xml = invalidCharsRegex.Replace(xml, string.Empty);
			object obj = null;
			XmlSerializer xmlSerializer = new XmlSerializer(t);
			using (StringReader input = new StringReader(xml))
			{
				using (XmlTextReader xmlReader = new XmlTextReader(input))
				{
					return xmlSerializer.Deserialize(xmlReader);
				}
			}
		}

		public static CreditCardType ParseCreditCardType(string card)
		{
			return (CreditCardType)Enum.Parse(typeof(CreditCardType), card, ignoreCase: true);
		}

		public static bool TryParseCreditCardType(string card, out CreditCardType? creditCardType)
		{
			creditCardType = null;
			try
			{
				creditCardType = (CreditCardType)Enum.Parse(typeof(CreditCardType), card, ignoreCase: true);
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
	}
}
