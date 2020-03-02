using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class ApplicationInformation
	{
		[JsonPropertyName("version")]
		public string Version { get; set; }
		
		[JsonPropertyName("authenticator")]
		public Uri AuthenticationUri { get; set; }
	}
}