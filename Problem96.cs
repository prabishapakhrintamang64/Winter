using System;
namespace Application
{
   class Problem96
   {
    public static void solution()
    {
        
        TomiokaGiyu a= new TomiokaGiyu();
         a.hasira1();
        HimejimaGiyomei obj1 =new HimejimaGiyomei();
         obj1.hasira2();
        UzuiTengen c=new UzuiTengen();
         c.hasira3();
        KochoShinobu d=new KochoShinobu();
         d.hasira4();
        KyojuroRengoku e=new KyojuroRengoku();
         e.hasira5();
        Sanemimonster f=new Sanemimonster();
         f.hasira6();
        KanrojiMitsuri g=new KanrojiMitsuri();
         g.hasira7();
        TokitoMuichiro h=new TokitoMuichiro();
         h.hasira8();
        Obonai i=new Obonai();
         i.hasira9();
                
        
    }
        class Hasiras
        {
         public void hasira()
         {
            Console.WriteLine("who fought with whom?");
         }

        }
        class TomiokaGiyu:Hasiras
        {
            public void hasira1()
            {
                Console.WriteLine(" Tomioka Giyu     : He has fought with Akaza in infinity castel.");

            }
           
        }
        class HimejimaGiyomei:Hasiras
        {
            public void hasira2()
            {
                Console.WriteLine(" Himejima Giyomei : He has fought with kokoshibo in infinity castel.");
            }
         
        }
        class UzuiTengen:Hasiras
        {
              public  void hasira3()
            {
                Console.WriteLine(" Uzui Tengen      : He has fought with kokoshibo in infinity castel.");
            }

        }
         class KochoShinobu:Hasiras
        {
              public void hasira4()
            {
                Console.WriteLine(" Kocho Shinobu    : He has fought with douma in infinity castel.");
            }
        }
         class KyojuroRengoku:Hasiras
        {
              public void hasira5()
            {
                Console.WriteLine(" Kyojuro Rengoku  : He has fought with akaza in mugen train and die.");
            }

        }
         class Sanemimonster:Hasiras
        {
              public void hasira6()
            {
                Console.WriteLine(" Sanemi monster   : He has fought with kokoshibo in infinity castel.");
            }

        }
         class KanrojiMitsuri:Hasiras
        {
              public void hasira7()
            {
                Console.WriteLine(" Kanroji Mitsuri  : He has fought with muzan in infinity castel.");
            }

        }
         class TokitoMuichiro:Hasiras
        {
              public void hasira8()
            {
                Console.WriteLine(" Tokito Muichiro  : He has fought with kokoshibo in infinity castel.");
            }

        }
         class Obonai:Hasiras
        {
              public void hasira9()
            {
                Console.WriteLine(" Obonai           : He has fought with muzan in infinity castel.");
            }

        }
        
   
   } 
}