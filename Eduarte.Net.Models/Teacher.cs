using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Teacher : UserInformation
	{
		[JsonPropertyName("begindatum")]
		public DateTimeOffset StartDateTime { get; set; }

		[JsonPropertyName("afkorting")]
		public string Abbreviation { get; set; }
	}
}