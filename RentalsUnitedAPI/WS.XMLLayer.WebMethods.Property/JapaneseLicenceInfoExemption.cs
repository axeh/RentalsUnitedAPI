using System.Xml.Serialization;

namespace WS.XMLLayer.WebMethods.Property
{
	[XmlType("JapaneseLicenceInfoExemption")]
	public class JapaneseLicenceInfoExemption
	{
		public string IssuingAuthority;

		public string UrlDocumentHotelsBusinessAct;

		public string UrlDocumentEconomicZoningAct;

		public string DescriptionEventMinpaku;

		public JapaneseLicenceInfoPermissionTypeEventMinpaku? PermissionTypeEventMinpaku;

		public string UrlDocumentEventMinpaku;

		public bool ShouldSerializeIssuingAuthority()
		{
			return !string.IsNullOrEmpty(IssuingAuthority);
		}

		public bool ShouldSerializeUrlDocumentHotelsBusinessAct()
		{
			return !string.IsNullOrEmpty(UrlDocumentHotelsBusinessAct);
		}

		public bool ShouldSerializeUrlDocumentEconomicZoningAct()
		{
			return !string.IsNullOrEmpty(UrlDocumentEconomicZoningAct);
		}

		public bool ShouldSerializeDescriptionEventMinpaku()
		{
			return !string.IsNullOrEmpty(DescriptionEventMinpaku);
		}

		public bool ShouldSerializePermissionTypeEventMinpaku()
		{
			return PermissionTypeEventMinpaku.HasValue;
		}

		public bool ShouldSerializeUrlDocumentEventMinpaku()
		{
			return !string.IsNullOrEmpty(UrlDocumentEventMinpaku);
		}

		internal bool IsNotEmpty()
		{
			if (!ShouldSerializeIssuingAuthority() && !ShouldSerializeUrlDocumentHotelsBusinessAct() && !ShouldSerializeUrlDocumentEconomicZoningAct() && !ShouldSerializeDescriptionEventMinpaku() && !ShouldSerializePermissionTypeEventMinpaku())
			{
				return ShouldSerializeUrlDocumentEventMinpaku();
			}
			return true;
		}
	}
}
