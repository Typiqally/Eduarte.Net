using System.Net.Http;
using System.Threading.Tasks;
using Eduarte.Net.OAuth.Extensions;

namespace Eduarte.Net.OAuth
{
	public class OAuthClient
	{
		private readonly DiscoveryDocument _discoveryDocument;
		private readonly ClientCredentials _credentials;
		private readonly HttpClient _httpClient;

		public OAuthClient(DiscoveryDocument discoveryDiscoveryDocument, ClientCredentials credentials)
		{
			_discoveryDocument = discoveryDiscoveryDocument;
			_credentials = credentials;

			_httpClient = new HttpClient();
		}

		public async Task<TokenResponse> RefreshTokenAsync(TokenResponse token)
		{
			var converter = new GrantTypeConverter();

			var parameters = _credentials.Dictionary();
			parameters.Add("grant_type", converter.ConvertToString(GrantType.RefreshToken));
			parameters.Add("refresh_token", token.RefreshToken);

			var requestMessage = new HttpRequestMessage(HttpMethod.Post, _discoveryDocument.TokenEndpoint)
			{
				Content = new FormUrlEncodedContent(parameters)
			};

			var response = await _httpClient.ExecuteRequestAsync<TokenResponse>(requestMessage);

			return response.Data;
		}
	}
}