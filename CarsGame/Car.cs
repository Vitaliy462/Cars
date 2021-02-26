using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Car
    {
        private int _number;
        protected int passedDist;
        
        Motor motor = new Motor();
        Accumulator accumulator = new Accumulator();
        Disc disc = new Disc();
        
        private bool isBroken;
        private bool noRepair;

        public Car()
        {
            _number = new Random().Next(1000, 9999);
        }

        public void Drive(Player player)
        {
            passedDist += 50;
            player.Balance += 10;

            motor.Stability -= 20;
            accumulator.Stability -= 20;
            disc.Stability -= 20;

            if (motor.Stability <= 0)
            {
                Console.WriteLine("Мотор сломался. Необходимо починить");
                isBroken = true;
            }
            else if (accumulator.Stability <= 0)
            {
                Console.WriteLine("Аккумулятор сломался. Необходимо починить");
                isBroken = true;
            }
            else if (disc.Stability <= 0)
            {
                Console.WriteLine("Диск сломался. Необходимо починить");
                isBroken = true;
            }
            else 
            {
                Console.WriteLine("Машина проехала " + passedDist + " km");
                
            }

            if (disc.State == 0 || motor.State == 0 || accumulator.State == 0)
            {
                noRepair = true;
            }
        }

        public void RepairMotor(Motor motor, Player player)
        {
            if (motor.State > 0 && player.Balance > motor.PriceRepair)
            {
                motor.State -= 1;
                player.Balance -= motor.PriceRepair;
                Console.WriteLine("Мотор починился за " + motor.PriceRepair + " його стійкість = " + motor.Stability + " та через " + motor.State + " кількість ремонту він вже выйде з ладу.");
                
                isBroken = false;
                
                
            }
            else 
            {
                Console.WriteLine("У игрока недостаточно средств");
                noRepair = true;
            }
        }

        public void RepairAccumulator(Accumulator accumulator, Player player)
        {
            if (accumulator.State > 0 && player.Balance > accumulator.PriceRepair)
            {
                player.Balance -= accumulator.PriceRepair;
                accumulator.State -= 1;
                Console.WriteLine("Аккумулятор починился за " + accumulator.PriceRepair + " його стійкість =" + accumulator.Stability + " та через " + accumulator.State + " кількість ремонту він вже выйде з ладу.");
                
                isBroken = false;
                
                
            }
            else
            {
                Console.WriteLine("У игрока недостаточно средств");
            }
        }

        public void RepairDisc(Disc disc, Player player)
        {
            if (disc.State > 0 && player.Balance > disc.PriceRepair)
            {
                player.Balance -= disc.PriceRepair;
                disc.State -= 1;
                Console.WriteLine("Диск починился за " + disc.PriceRepair + " його стійкість = " + disc.Stability + " та через " + disc.State + " кількість ремонту він вже выйде з ладу.");
                
                isBroken = false;
                
            }
            else
            {
                Console.WriteLine("У игрока недостаточно средств");
            }
        }

        public int Number { get { return _number; }  }
        public bool IsBroken { get { return isBroken; } }
        public bool NoRepair { get { return noRepair; } }
    }
}
