using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_3_OleksandrLapin
{
    public class CurrencyRateTable
    {
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public List<CurrencyRate> Rates { get; set; }
    }

    public class CurrencyRate
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public float Mid { get; set; }
    }
}
