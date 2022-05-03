using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TeamPlannerTFT.Core.Contracts.Services;
using TeamPlannerTFT.Core.Dtos;
using TeamPlannerTFT.Core.Helpers;

namespace TeamPlannerTFT.Core.Services
{
    public class UnitService : IUnitService
    {

        private readonly HttpClient _httpClient;
        HttpClientHandler clientHandler;

        public UnitService()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri("https://localhost:44308/api/") };
        }

        public async Task<IEnumerable<UnitDto>> GetUnitsAsync()
        {
            var items = new List<UnitDto>();
            HttpResponseMessage response = await _httpClient.GetAsync("units");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                items = await Json.ToObjectAsync<List<UnitDto>>(content);
            }
            return items;
        }

        public async Task<UnitDto> CreateUnitAsync(UnitDto unit)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("units", unit);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<UnitDto>();
        }

        public async void UpdateUnitAsync(UnitDto unit)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"units/{unit.Id}", unit);
            response.EnsureSuccessStatusCode();
        }

        public async Task<bool> DeleteUnitAsync(UnitDto unit)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"units/{unit.Id}");
            return response.IsSuccessStatusCode;
        }
    }
}
