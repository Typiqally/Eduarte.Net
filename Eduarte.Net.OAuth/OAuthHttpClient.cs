using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Eduarte.Net.OAuth.Extensions;

namespace Eduarte.Net.OAuth
{
	public class OAuthHttpClient : HttpClient
	{
		private readonly OAuthClient _client;
		private TokenResponse _token;

		public OAuthHttpClient(OAuthClient client, TokenResponse token)
		{
			_client = client;
			_token = token;
			
			this.SetBearerToken(token.AccessToken);
		}

		public new async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption httpCompletionOption)
		{
			var response = await base.SendAsync(request);
			
			if (response.StatusCode != HttpStatusCode.Unauthorized) return response;
			
			_token = await _client.RefreshTokenAsync(_token);
			this.SetBearerToken(_token.AccessToken);
			
			var retryRequest = new HttpRequestMessage(request.Method, request.RequestUri);	
			response = await base.SendAsync(retryRequest);

			return response;
		}
	}
}