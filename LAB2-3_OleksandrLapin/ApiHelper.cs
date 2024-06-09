using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_3_OleksandrLapin
{
    public static class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Country>> GetCountriesAsync()
        {
            string url = "https://restcountries.com/v3.1/all";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Country>>(response);
        }

        public static async Task<List<CurrencyRateTable>> GetCurrencyRatesAsync(string table)
        {
            string url = $"https://api.nbp.pl/api/exchangerates/tables/{table}/";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<CurrencyRateTable>>(response);
        }

        public static async Task<WeatherData> GetWeatherDataAsync(float latitude, float longitude)
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude:0.00}&longitude={longitude:0.00}&current=temperature_2m";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherData>(response);
        }

        public static async Task<TimeData> GetTimeDataAsync(float latitude, float longitude)
        {
            string url = $"https://timeapi.io/api/Time/current/coordinate?latitude={latitude:0.00}&longitude={longitude:0.00}";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<TimeData>(response);
        }
    }
    }
