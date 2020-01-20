using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.Services
{
    public class CounterService
    {
        public int Counter { get; private set; }

        public void Increment()
        {
            Counter++;
        }        
    }
}
