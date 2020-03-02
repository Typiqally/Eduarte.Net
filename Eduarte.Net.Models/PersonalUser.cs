using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class PersonalUser : Account
	{
		[JsonPropertyName("deelnemer")]
		public PersonalInformation PersonalInformation { get; set; }
	}
}