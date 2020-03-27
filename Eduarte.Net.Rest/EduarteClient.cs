using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Eduarte.Net.Models;
using NETCore.OAuth.Client;
using NETCore.OAuth.Client.Extensions;
using NETCore.OAuth.Core;
using NETCore.OAuth.Core.Extensions;

namespace Eduarte.Net.Rest
{
    public class EduarteClient : IEduarteClient
    {
        private readonly OAuthHttpClient _oAuthHttpClient;

        public EduarteClient(ApplicationUrl applicationUrl, OAuthClient authClient, TokenResponse token)
        {
            _oAuthHttpClient = new OAuthHttpClient(authClient, token);
            _oAuthHttpClient.HttpClient.BaseAddress = applicationUrl.RestUri.Normalize();
            _oAuthHttpClient.HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<List<Appointment>> RequestAppointmentsAsync(AppointmentsFilter filter = null)
        {
            var uri = "afspraak";

            if (filter != null)
            {
                uri = uri.AppendQueryParameters(filter.Parameters);
            }

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await _oAuthHttpClient.SendAsync<ItemCollectionResult<Appointment>>(requestMessage);

            var collection = response.Data;
            return collection.Items;
        }

        public async Task<PersonalUser> RequestCurrentUserAsync()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "account/me");
            var response = await _oAuthHttpClient.SendAsync<PersonalUser>(requestMessage);

            return response.Data;
        }
    }
}