using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class UserInformation
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		
		public Permission[] Permissions { get; set; }

		[JsonPropertyName("roepnaam")]
		public string FirstName { get; set; }

		[JsonPropertyName("voornamen")]
		public string FirstNames { get; set; }
		
		[JsonPropertyName("voorvoegsel")]
		public string Prefix { get; set; }

		[JsonPropertyName("voorletters")]
		public string Initials { get; set; }

		[JsonPropertyName("achternaam")]
		public string LastName { get; set; }
		
		[JsonPropertyName("geslacht")]
		public string Gender { get; set; }
	}
}