using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    public class InternationalCall : Call
    {
        public string Country { get; set; }

        public override decimal CalculateCost()
        {
            decimal costPerMinute = GetCostPerMinuteByCountry(Country);
            return Duration * costPerMinute;
        }

        private decimal GetCostPerMinuteByCountry(string country)
        {
            decimal costPerMinute = 0.50m;

            if (country == "Brasil")
            {
                costPerMinute = 0.60m;
            }
            else if (country == "Argentina")
            {
                costPerMinute = 0.70m;
            }

            return costPerMinute;
        }
    }
}
