using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    public class NationalCall : Call
    {
        public string Location { get; set; }

        public override decimal CalculateCost()
        {            
            decimal costPerMinute = GetCostPerMinuteByLocation(Location);
            return Duration * costPerMinute;
        }

        private decimal GetCostPerMinuteByLocation(string location)
        {
            decimal costPerMinute = 0.15m;

            if (location == "Tigre")
            {
                costPerMinute = 0.20m;
            }
            else if (location == "Caba")
            {
                costPerMinute = 0.25m;
            }

            return costPerMinute;
        }
    }

}
