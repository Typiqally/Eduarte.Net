using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Eduarte.Net.Models;
using Eduarte.Net.OAuth;
using Eduarte.Net.OAuth.Extensions;

namespace Eduarte.Net.Rest
{
	public class EduarteClient : IEduarteClient
	{
		private readonly OAuthHttpClient _oAuthHttpClient;

		public EduarteClient(ApplicationUrl applicationUrl, OAuthClient authClient, TokenResponse token)
		{
			_oAuthHttpClient = new OAuthHttpClient(authClient, token)
			{
				BaseAddress = applicationUrl.RestUri.Normalize(),
				DefaultRequestHeaders =
				{
					Accept = {MediaTypeWithQualityHeaderValue.Parse("application/json")},
				}
			};

			_oAuthHttpClient.SetBearerToken(token.AccessToken);
		}

		public async Task<List<Appointment>> RequestAppointmentsAsync(AppointmentsFilter filter = null)
		{
			var uri = "afspraak";

			if (filter != null)
			{
				uri = uri.AppendQueryParameters(filter.Parameters);
			}

			var response = await _oAuthHttpClient.ExecuteRequestAsync<ItemCollectionResult<Appointment>>(uri);

			var collection = response.Data;
			return collection.Items;
		}

		public async Task<PersonalUser> RequestCurrentUserAsync()
		{
			var response = await _oAuthHttpClient.ExecuteRequestAsync<PersonalUser>("account/me");

			return response.Data;
		}
	}
}