using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class ApplicationUrl
	{
		[JsonPropertyName("organisatie")]
		public string Name { get; set; }
		
		[JsonPropertyName("organisatieUuid")]
		public string Uuid { get; set; }
		
		[JsonPropertyName("restUrl")]
		public Uri RestUri { get; set; }
	}
}