using System;

namespace P225ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(2000);
            vehicle.Color = "Red";

            Car car = new Car("BMW", "F10", 5, 100, 2022);
            car.CurrentFuel = 65;
            car.Color = "M Paket";

            Console.WriteLine(car.CurrentFuel);
            car.AddFuel(5);
            Console.WriteLine(car.CurrentFuel);
            car.AddFuel(5);
            Console.WriteLine(car.CurrentFuel);

            car.ShowInfo();
            
            car.Drive(150);
        }
    }
}
