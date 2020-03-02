using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Rest
{
	public class ItemCollectionResult<T>
	{
		[JsonPropertyName("items")]
		public List<T> Items { get; set; }
	}
}