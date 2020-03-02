using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Group
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		public Permission[] Permissions { get; set; }

		[JsonPropertyName("begindatum")]
		public DateTimeOffset Begindatum { get; set; }

		[JsonPropertyName("naam")]
		public string Naam { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }
	}
}