using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_3_OleksandrLapin
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Country
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; }

        [JsonPropertyName("currencies")]
        public Dictionary<string, Currency> Currencies { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        public override string ToString()
        {
            return Name.Common;
        }
    }

    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }
    }


}
