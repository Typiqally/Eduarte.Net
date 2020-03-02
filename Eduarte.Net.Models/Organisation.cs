using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Organisation
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		public Permission[] Permissions { get; set; }

		[JsonPropertyName("naam")]
		public string Name { get; set; }

		[JsonPropertyName("beheer")]
		public bool Owner { get; set; }

		[JsonPropertyName("uuid")]
		public string Uuid { get; set; }
	}
}