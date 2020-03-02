using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class AppointmentType
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		public Permission[] Permissions { get; set; }

		[JsonPropertyName("naam")]
		public string Naam { get; set; }

		[JsonPropertyName("category")]
		public string Category { get; set; }
	}
}