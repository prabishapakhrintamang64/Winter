using System;
namespace Application
{
    public class Problem105
    {
        public static void solution()
        {
            Software obj=new Software("ADOBE ACROBAT CAPTURE", 20000);
              Software obj2=new Software("Capybara", 102030);
            Software[] softwares= new Software[]{obj,obj2};

            Hardware obj1= new Hardware("HP Z8",42884, softwares);
            Hardware[] hardwares= new Hardware[]{obj1};

            Computer obj3= new Computer("HP Omen 45L", 100244, hardwares);
            obj3.DisplayComputer();
        }

        class Software
        {
            public string Name;
            public int Price;
            public Software(string name, int price)
            {
                Name=name;
                Price=price;
            }
            public void Displaysoftware()
            {
                Console.WriteLine($"SoftwareName:{Name}, SoftwarePrice:{Price}");
            }
            public void AddSoftwarename(string name, int price)
            {
                this.Name = name;
                this.Price= price;
            }

        }
        class Hardware
        {
            public string Name;
            public int Price;
            public Software[] Softwares;
            public Hardware(string name, int price, Software[] softwares)
            {
               Name=name;
               Price=price;
               Softwares=softwares;

            }
            public void DisplayHardware()
            {
                Console.WriteLine($"HardwareName:{Name}, HardwarePrice:{Price}");
                Console.WriteLine("Software:");
                foreach(var Software in Softwares)
                {
                    Software.Displaysoftware();

                }

            }
        }
        class Computer
        {
            public string Name;
            public int Price;
            public Hardware[] Hardwares;
            public Computer(string name, int price, Hardware[] hardwares)
            {
                Name=name;
                Price=price;
                Hardwares=hardwares;
            }
            public void DisplayComputer()
            {
                Console.WriteLine("Computer:");
                Console.WriteLine($"ComputerName:{Name}, ComputerPrice:{Price}");
                Console.WriteLine("Hardware:");
                foreach(var Hardware in Hardwares)
                {
                    Hardware.DisplayHardware();
                }
            }

        }
    }
}