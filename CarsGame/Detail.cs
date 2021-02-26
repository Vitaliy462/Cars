using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Detail
    {
        protected int _stability;
        protected double _priceBuy;
        protected int _state;
        protected double _priceRepair;
        

        //public Detail()         
        //{
        //    _stability = 100;
        //    _priceBuy = 30;
        //    _priceRepair = 5;
        //    _state = 5;
        //}

        public int Stability
        {
            get { return _stability; }
            set { _stability = value; }
        }

        public double PriceBuy
        {
            get { return _priceBuy; }
            set { _priceBuy = value; }
        }

        public double PriceRepair
        {
            get { return _priceRepair; }
            set { _priceRepair = value; }
        }

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        
    }
}
