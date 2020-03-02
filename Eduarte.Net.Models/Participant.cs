using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Participant
	{
		[JsonPropertyName("medewerker")]
		public Teacher Teacher { get; set; }

		[JsonPropertyName("groep")]
		public Group Group { get; set; }
	}
}