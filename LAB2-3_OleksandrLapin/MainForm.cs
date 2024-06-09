using Newtonsoft.Json.Linq;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LAB2_3_OleksandrLapin
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private JArray countriesData;

        public MainForm()
        {
            InitializeComponent();
            LoadRegionsAndSubRegions();
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            await LoadDataFromAPI();
        }

        private async Task LoadDataFromAPI()
        {
            string apiUrl = "https://restcountries.com/v3.1/all";
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                countriesData = JArray.Parse(responseBody);

                PopulateRegions();
                txtCountriesStatus.Text = "Dane zostały załadowane pomyślnie!";
            }
            catch (HttpRequestException httpEx)
            {
                txtCountriesStatus.Text = $"Błąd żądania: {httpEx.Message}";
            }
            catch (Exception ex)
            {
                txtCountriesStatus.Text = $"Błąd: {ex.Message}";
            }
        }

        private void PopulateRegions()
        {
            var regions = new HashSet<string>();
            foreach (var country in countriesData)
            {
                var region = country["region"]?.ToString();
                if (!string.IsNullOrEmpty(region))
                {
                    regions.Add(region);
                }
            }
            cmbRegion.Items.Clear();
            cmbRegion.Items.AddRange(regions.ToArray());
        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegion = cmbRegion.SelectedItem.ToString();
            PopulateSubRegions(selectedRegion);
        }

        private void PopulateSubRegions(string region)
        {
            var subRegions = new HashSet<string>();
            foreach (var country in countriesData)
            {
                if (country["region"]?.ToString() == region)
                {
                    var subRegion = country["subregion"]?.ToString();
                    if (!string.IsNullOrEmpty(subRegion))
                    {
                        subRegions.Add(subRegion);
                    }
                }
            }
            cmbSubRegion.Items.Clear();
            cmbSubRegion.Items.AddRange(subRegions.ToArray());
        }

        private void cmbSubRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSubRegion = cmbSubRegion.SelectedItem.ToString();
            PopulateCountries(selectedSubRegion);
        }

        private void PopulateCountries(string subRegion)
        {
            lstCountries.Items.Clear();
            foreach (var country in countriesData)
            {
                if (country["subregion"]?.ToString() == subRegion)
                {
                    lstCountries.Items.Add(country["name"]["common"].ToString());
                }
            }
        }

        private void btnLoadCountryData_Click(object sender, EventArgs e)
        {
            var selectedCountryName = lstCountries.SelectedItem?.ToString();
            if (selectedCountryName != null)
            {
                DisplayCountryData(selectedCountryName);
            }
        }

        private void DisplayCountryData(string countryName)
        {
            var selectedCountry = countriesData.FirstOrDefault(c => c["name"]["common"].ToString() == countryName);
            if (selectedCountry != null)
            {
                lblCountryName.Text = selectedCountry["name"]["common"]?.ToString();
                lblCountryOfficialName.Text = selectedCountry["name"]["official"]?.ToString();
                lblCountryNativeName.Text = selectedCountry["name"]["nativeName"]?["por"]?["official"]?.ToString();
                lblCapital.Text = selectedCountry["capital"]?.FirstOrDefault()?.ToString();
                pbFlag.Load(selectedCountry["flags"]?["png"]?.ToString());
                pbCoatOfArms.Load(selectedCountry["coatOfArms"]?["png"]?.ToString());

                dgvCurrencies.Rows.Clear();
                var currencies = selectedCountry["currencies"];
                if (currencies != null)
                {
                    foreach (var currency in currencies.Children())
                    {
                        var currencyData = currency.First();
                        dgvCurrencies.Rows.Add(currency.Path, currencyData["name"]?.ToString(), currencyData["symbol"]?.ToString());
                    }
                }

              
            }
        }

        private void LoadRegionsAndSubRegions()
        {
            cmbRegion.SelectedIndexChanged += new EventHandler(cmbRegion_SelectedIndexChanged);
            cmbSubRegion.SelectedIndexChanged += new EventHandler(cmbSubRegion_SelectedIndexChanged);
            btnLoadCountryData.Click += new EventHandler(btnLoadCountryData_Click);
        }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string PolishName { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
