using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Motor : Detail
    {

        public Motor()
        {
            _stability = 80;
            _priceBuy = 50;
            _priceRepair = 20;
            _state = 5;
        }
    }
}
