using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Disc : Detail
    {
        public Disc()
        {
            _stability = 60;
            _priceBuy = 30;
            _priceRepair = 10;
            _state = 3;
        }
    }
}
