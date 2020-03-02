using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Operation
	{
		Create,
		Delete,
		Read,
		Update
	}
}