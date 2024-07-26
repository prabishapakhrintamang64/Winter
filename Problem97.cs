using System;
namespace Application
{ 
    public class Problem97
    {
        public static void solution()
        {  
           
            

        }
        public interface Writeable
        {
            public void write();
           

        }
        public interface Erasable
        {
            public string erase();

        }
       
        public class FILA: Writeable
        {
            public void write()
            {
                Console.WriteLine("i can write.");
            }

        }
        public class DOMS:Writeable, Erasable
        {
            public string erase()
            {
                return "I can erase your thoughts.";
            }
            public void write()
            {
                Console.WriteLine("I can write in your copy.");
            } 
        }
       public class Nataraj: Writeable, Erasable
    {
        public void write()
        {
            Console.WriteLine("I can write.");
        }
        public string erase()
        {
            return "I can erase your thoughts.";
        }

    }
    


                  
    }
}
