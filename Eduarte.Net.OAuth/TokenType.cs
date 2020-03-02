using System.Text.Json.Serialization;

namespace Eduarte.Net.OAuth
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum TokenType
	{
		Bearer
	}
}