using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class PersonalInformation : UserInformation
	{
		[JsonPropertyName("deelnemernummer")]
		public int Id { get; set; }
		
		[JsonPropertyName("geboortedatum")]
		public DateTimeOffset DateOfBirth { get; set; }

		[JsonPropertyName("pasfotoUrl")]
		public Uri ProfilePictureUrl { get; set; }
	}
}