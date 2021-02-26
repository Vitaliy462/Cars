using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Accumulator : Detail
    {
        public Accumulator()
        {
            _stability = 120;
            _priceBuy = 70;
            _priceRepair = 40;
            _state = 7;
        }
    }
}
