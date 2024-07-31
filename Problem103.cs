using System;
namespace Application
{
    public class Problem103
    {
        public static void solution()
        {
            Soul obj = new Soul("grey");
            Soul[] souul = new Soul[]{obj};

            Bones obj2= new Bones("white",206,souul);
            Bones[] bonnie = new Bones[] {obj2};

            Body obj3= new Body("pale", bonnie);
            obj3.Display();

        }
        class Soul
        {
            public string Color;
            public Soul( string color)
            {
               Color= color;     

            }
            public void Display()
            {
                Console.WriteLine($"Color: {Color}"); 

            }

        }
        class Bones
        {
            public string Color;
            public int Total; 
             public Soul[] Souls;
            public Bones( string color, int total, Soul[] souls)
            {
                Color= color;
                Total= total;
                Souls=souls;

            }
            public void Display()
            {
                Console.WriteLine($"Color: {Color},Total:{Total}");
                Console.WriteLine("Soul:");
                foreach(var Soul in Souls)
                {
                    Soul.Display();
                }

            }

        }
        class Body
        {
            public string Color;
            public Bones[] Boneess;

            public Body(string color,  Bones[] boneess)
            {
                Color= color;
                Boneess=boneess;

            }
            public void Display()
            {
                Console.WriteLine("Body:");
                Console.WriteLine($"Color:{Color}");
                Console.WriteLine("Bones:");
                foreach(var Bones in Boneess)
                {
                    Bones.Display();
                }

            }

        }
    }
}