using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Account
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		public Permission[] Permissions { get; set; }

		[JsonPropertyName("organisatie")]
		public Organisation Organisation { get; set; }

		[JsonPropertyName("gebruikersnaam")]
		public string UserName { get; set; }

		[JsonPropertyName("wachtwoordGewijzigdOp")]
		public DateTimeOffset PasswordLastChanged { get; set; }

		[JsonPropertyName("eduArteWachtwoordInGebruik")]
		public bool UseEduartePassword { get; set; }

		[JsonPropertyName("twoFactorEnabled")]
		public bool TwoFactorEnabled { get; set; }

		[JsonPropertyName("accountPermissions")]
		public Permission[] AccountPermissions { get; set; }

		[JsonPropertyName("taalkeuze")]
		public string Language { get; set; }

		[JsonPropertyName("agendaWeergave")]
		public string AgendaViewType { get; set; }
	}
}