using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    public class LocalCall : Call
    {
        public int Hour { get; set; }
        public DayOfWeek Day { get; set; }

        public override decimal CalculateCost()
        {
            decimal costPerMinute = 0.10m;
            if (Day != DayOfWeek.Saturday && Day != DayOfWeek.Sunday)
            {
                if (Hour >= 8 && Hour < 20)
                {
                    costPerMinute = 0.20m;
                }
            }
            return Duration * costPerMinute;
        }
    }
}
