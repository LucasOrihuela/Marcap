using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthlyBilling monthlyBilling = new MonthlyBilling();

            // Agrego algunas llamadas para probar
            LocalCall localCall1 = new LocalCall { Duration = 30, Hour = 10, Day = DayOfWeek.Monday };
            LocalCall localCall2 = new LocalCall { Duration = 20, Hour = 19, Day = DayOfWeek.Tuesday };
            NationalCall nationalCall1 = new NationalCall { Duration = 15, Location = "Tigre" };
            NationalCall nationalCall2 = new NationalCall { Duration = 25, Location = "Caba" };
            InternationalCall internationalCall1 = new InternationalCall { Duration = 10, Country = "Argentina" };
            InternationalCall internationalCall2 = new InternationalCall { Duration = 35, Country = "Brasil" };

            monthlyBilling.AddCall(localCall1);
            monthlyBilling.AddCall(localCall2);
            monthlyBilling.AddCall(nationalCall1);
            monthlyBilling.AddCall(nationalCall2);
            monthlyBilling.AddCall(internationalCall1);
            monthlyBilling.AddCall(internationalCall2);

            // Imprimo factura en consola
            monthlyBilling.PrintInvoice();

            // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
