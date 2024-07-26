using System;
namespace Application
{
   class Problem85
    {
         public  string firstname;
         public  string lastname;
       public Problem85(string firstnames, string lastnames) 
       {
        this.firstname = firstnames;
        this.lastname = lastnames;
       }
       public void showfullname()
       {
        Console.WriteLine("firstname: "+ firstname+ "lastname: "+ lastname);
       }
       public static void solution()
       {
        Problem85 p= new Problem85("pabitra","thapa");
        Problem85 q= new Problem85("nisha","shrestha");
        Problem85 r= new Problem85("namrata","rana");
        Problem85 s= new Problem85("prabisha","pakhrin");

         p.showfullname();
         q.showfullname();
         r.showfullname();
         s.showfullname();

       }
    }
}