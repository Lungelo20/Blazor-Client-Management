using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace RTT.Client.Services.ClientDetailService
{
    public class ClientDetailService : IClientDetailService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ClientDetailService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<ClientDetails> ClientDetail { get; set; } = new List<ClientDetails>();
        public List<ClientContact> ClientContacts { get; set; } = new List<ClientContact>();
        public List<ClientAddress> ClientAddresses { get; set; } = new List<ClientAddress>();

        public async Task AddClient(ClientDetails client)
        {
            var result = await _http.PostAsJsonAsync("api/ClientDetail", client);
            await SetClient(result);
        }

        private async Task SetClient(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<ClientDetails>>();
            ClientDetail = response;
            _navigationManager.NavigateTo("clients");
        }

        public async Task DeleteClient(int id)
        {
            var result = await _http.DeleteAsync($"api/ClientDetail/{id}");
            await SetClient(result);
        }
       
        public async Task GetContacts()
        {
            var result = await _http.GetFromJsonAsync<List<ClientContact>>("api/ClientDetail/ClientContact");
            if (result != null)
            {
                ClientContacts = result;
            }
            else
            {
                throw new Exception("No Client Found here!");
            }
        }
        public async Task GetAddresses()
        {
            var result = await _http.GetFromJsonAsync<List<ClientAddress>>("api/ClientDetail/ClientAddress");
            if (result != null)
            {
                ClientAddresses = result;
            }
            else
            {
                throw new Exception("No Client Found here!");
            }
        }

        public async Task<ClientDetails> GetAClient(int id)
        {
            var result = await _http.GetFromJsonAsync<ClientDetails>($"api/ClientDetail/{id}");
            if (result != null)
                return result;
            throw new Exception("No Client Found here!");
        }

        public async Task GetAllClients()
        {
            var result = await _http.GetFromJsonAsync<List<ClientDetails>>("api/ClientDetail");
            if(result != null)
            {
                ClientDetail = result;
            }
        }
        public async Task UpdateClient(ClientDetails client)
        {
            var result = await _http.PutAsJsonAsync($"api/ClientDetail/{client.Id}", client);
            await SetClient(result);
        }
    }
}
