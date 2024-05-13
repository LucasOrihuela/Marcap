using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    public class MonthlyBilling
    {
        private List<Call> calls = new List<Call>();

        public void AddCall(Call call)
        {
            calls.Add(call);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var call in calls)
            {
                totalCost += call.CalculateCost();
            }
            return totalCost;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Monthly Invoice:");
            foreach (var call in calls)
            {
                Console.WriteLine($"Duration: {call.Duration} minutes - Cost: {call.CalculateCost():C}");
            }
            Console.WriteLine($"Total Cost: {CalculateTotalCost():C}");
        }
    }
}
