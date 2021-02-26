using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame
{
    class Program
    {

        //public string start(string num)
        //{
        //    string mess;
        //    switch (num)
        //    {

        //    }
        //}

        static void Main(string[] args)
        {
            bool endApp = false;
            int option = 0;
            Player player = new Player("User1");
            //player.Balance = 500;
            bool stop = false;

            Console.WriteLine("Welcome " + player.Name);

            while (!stop)
            {
                
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - check player balance");
                Console.WriteLine("\t2 - create a car");
                Console.WriteLine("\t3 - exit");

                Console.Write("Your option? ");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Your balance " + player.Balance);
                        break;
                    case 2:
                        Car car = new Car();
                        Motor motor = new Motor();
                        Accumulator accumulator = new Accumulator();
                        Disc disc = new Disc();
                        while (!endApp)
                        {
                            Console.WriteLine("Your car " + car.Number);

                            Console.WriteLine("\t1 - add a car to the player");
                            Console.WriteLine("\t2 - drive a car");
                            Console.WriteLine("\t3 - check player balance " + player.Balance);

                            Console.Write("Your option? ");

                            while (!car.NoRepair)
                            {
                                int.TryParse(Console.ReadLine(), out option);
                                switch (option)
                                {
                                    case 1:
                                        player.AddCar(car);
                                        foreach (var car1 in player.CarsList)
                                        {
                                            Console.WriteLine("Player " + player.Name + " has car with the number " + car1.Number);
                                        }

                                        break;
                                    case 2:
                                        car.Drive(player);
                                        break;
                                    case 3:
                                        Console.WriteLine("Your balance " + player.Balance);
                                        break;
                                    default:
                                        Console.WriteLine("Error! No such action...");
                                        break;
                                }
                                if (car.IsBroken)
                                {
                                    Console.WriteLine("\t2 - check player balance");
                                    Console.WriteLine("\t3 - repair a motor");
                                    Console.WriteLine("\t4 - repair an accumulator");
                                    Console.WriteLine("\t5 - repair a disc");
                                    Console.Write("Your option? ");
                                    int.TryParse(Console.ReadLine(), out option);
                                    switch (option)
                                    {
                                        case 2:
                                            Console.WriteLine("Your balance " + player.Balance);
                                            break;
                                        case 3:
                                            car.RepairMotor(motor, player);
                                            break;
                                        case 4:
                                            car.RepairAccumulator(accumulator, player);
                                            break;
                                        case 5:
                                            car.RepairDisc(disc, player);
                                            break;
                                    }
                                }
                                Console.WriteLine("IS NoRepair: " + car.NoRepair);

                            }
                            Console.Write("Press 's' and Enter to close the app, or press any other key and Enter to continue: ");
                            if (Console.ReadLine() == "s")
                            { endApp = true; }

                            Console.WriteLine("\n");

                        }
                        break;


                    case 3:
                        stop = true;
                        break;

                    default:
                        Console.WriteLine("Error! No such action...");
                        break;

                }
                
            }

        }

    }
}

