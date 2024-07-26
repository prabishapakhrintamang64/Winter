using System;
namespace Application
{
      public class Glasses
    {
        public String colors ="transparent";

        public Glasses()
        {
        }
        public void color()
        {
         Console.WriteLine(colors);
        }
        public Glasses(string c)
        {
            colors=c;
        }
    }
}