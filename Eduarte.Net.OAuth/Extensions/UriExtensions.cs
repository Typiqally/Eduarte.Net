using System;

namespace Eduarte.Net.OAuth.Extensions
{
	public static class UriExtensions
	{
		public static Uri Normalize(this Uri uri)
		{
			return new Uri(uri + "/");
		}
	}
}