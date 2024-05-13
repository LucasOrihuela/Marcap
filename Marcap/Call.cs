using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcap
{
    public abstract class Call
    {
        public int Duration { get; set; }

        public abstract decimal CalculateCost();
    }
}
