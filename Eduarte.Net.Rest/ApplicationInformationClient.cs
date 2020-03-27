using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Eduarte.Net.Models;
using NETCore.OAuth.Client.Extensions;

namespace Eduarte.Net.Rest
{
	public class ApplicationInformationClient
	{
		private readonly Uri _uri;
		private readonly HttpClient _httpClient;
		
		public ApplicationInformationClient(Uri uri)
		{
			_uri = uri;
			_httpClient = new HttpClient
			{
				DefaultRequestHeaders =
				{
					Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json")}
				}
			};
		}
		
		public static ApplicationInformationClient Default()
			=> new ApplicationInformationClient(new Uri("https://appinfo.educus.nl/"));

		public async Task<ApplicationInformation> RequestApplicationInformation()
		{
			var response = await _httpClient.SendAsync<ApplicationInformation>(_uri.ToString());
			return response.Data;
		}

		public async Task<List<ApplicationUrl>> RequestOrganisations()
		{
			var applicationInformation = await RequestApplicationInformation();
			var organisationsUri = $"{applicationInformation.AuthenticationUri}app/endpoints";

			var response = await _httpClient.SendAsync<ItemCollectionResult<ApplicationUrl>>(organisationsUri);
			
			var collection = response.Data;
			return collection.Items;
		}
	}
}