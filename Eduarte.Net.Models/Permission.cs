using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Permission
	{
		[JsonPropertyName("full")]
		public string Full { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("operations")]
		public Operation[] Operations { get; set; }

		[JsonPropertyName("instances")]
		public string[] Instances { get; set; }
	}
}