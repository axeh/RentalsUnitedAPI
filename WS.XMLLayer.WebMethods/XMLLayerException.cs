using System;

namespace WS.XMLLayer.WebMethods
{
	public class XMLLayerException : Exception
	{
		private object[] _parameters;

		public StatusInfoCode ResponseStatusInfoCode
		{
			get;
		}

		public StatusInfo ResponseStatusInfo => StatusInfo.GetStatus(ResponseStatusInfoCode);

		public XMLLayerException(StatusInfoCode responseStatusInfoCode)
		{
			ResponseStatusInfoCode = responseStatusInfoCode;
		}

		public XMLLayerException(StatusInfoCode responseStatusInfoCode, params object[] parameters)
			: this(responseStatusInfoCode)
		{
			_parameters = parameters;
		}

		public string GetStatusMessage()
		{
			return ResponseStatusInfo.ReplaceValue(_parameters);
		}
	}
}
