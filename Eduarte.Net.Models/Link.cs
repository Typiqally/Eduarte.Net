using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Link
	{
		[JsonPropertyName("id")]
		public long Id { get; set; }

		[JsonPropertyName("rel")]
		public string Rel { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("href")]
		public Uri Href { get; set; }
	}
}