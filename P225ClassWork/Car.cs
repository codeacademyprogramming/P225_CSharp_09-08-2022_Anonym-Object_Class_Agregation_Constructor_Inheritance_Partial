using System;
using System.Collections.Generic;
using System.Text;

namespace P225ClassWork
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string brand, string model, double fuelfor1km, double fuelcapacity,int year):base(year)
        {
            Brand = brand;
            Model = model;
            FuelFor1Km = fuelfor1km;
            FuelCapacity = fuelcapacity;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Model} {FuelCapacity} {FuelFor1Km} {CurrentFuel} {Color} {Year}");
        }

        public void AddFuel(double fuel)
        {
            if ((CurrentFuel+fuel) < FuelCapacity)
            {
                CurrentFuel += fuel;
            }
            else
            {
                Console.WriteLine("Fuel Capacity Deyerini Asir");
            }
        }

        public void Drive(double km)
        {
            Console.WriteLine($"Gedilecek {km} qeder");
        }
    }
}
