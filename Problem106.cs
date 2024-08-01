using System;

namespace Application
{
    public class Problem106
    {
        public static void solution()
        {
            Supra supra1 = new Supra("Toyota Supra", 8000000, true);
            Supra supra2 = new Supra("Toyota Supra 2", 8500000, false);

            Supra[] supras = new Supra[] { supra1, supra2 };

            Car car = new Car("Supra", supras);
            Car[] cars = new Car[] { car };

            Company company = new Company("Toyota Motor Corporation", cars);
            
            Console.WriteLine("All About Supra:");

            Supra supra3 = new Supra("Toyota Supra 3", 9000000, true);
            car.AddSupra(supra3);

            company.DisplayCompany();
        }

        class Supra
        {
            public string Model;
            public int Price;
            public bool Security;

            public Supra(string model, int price, bool security)
            {
                Model = model;
                Price = price;
                Security = security;
            }

            public void DisplaySupra()
            {
                Console.WriteLine($"Supra Model: {Model}, Supra Price: {Price}, Supra Security: {Security}");
            }
        }

        class Car
        {
            public string Name;
            public Supra[] Supras;

            public Car(string name, Supra[] supras)
            {
                Name = name;
                Supras = supras;
            }

            public void AddSupra(Supra supra)
            {
                Array.Resize(ref Supras, Supras.Length + 1);
                Supras[Supras.Length - 1] = supra;
            }

            public void DisplayCar()
            {
                Console.WriteLine($"Car Name: {Name}");
                Console.WriteLine("Supra:");
                foreach (var supra in Supras)
                {
                    supra.DisplaySupra();
                }
            }
        }

        class Company
        {
            public string Name;
            public Car[] Cars;

            public Company(string name, Car[] cars)
            {
                Name = name;
                Cars = cars;
            }

            public void DisplayCompany()
            {
                Console.WriteLine($"Company Name: {Name}");
                Console.WriteLine("Cars:");
                foreach (var car in Cars)
                {
                    car.DisplayCar();
                }
            }
        }
    }
}
