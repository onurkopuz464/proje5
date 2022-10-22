using System;

namespace c
{
    class Program
    {
        
        static void Main(string[] args)
        {
          int day = DateTime.Now.Day;
          int Hour = DateTime.Now.Hour;

          int kalan =30-day;
          
          if(kalan != 0)
          {
            Console.WriteLine(kalan + " "+ "gün kaldı." );
          }
          else if(kalan < 0)
          {
            Console.WriteLine("Gününüz kalmadı.");

          }
         
          else if(kalan == 0)
          {
            Console.WriteLine("Son gününüz");
          }

          string sonuc = Hour<=18 ? "Sabah" : "Akşam";
          string sonuc1 = kalan > 0 && kalan !=0 ? kalan + " "+ "gün kaldı."  : "Gününüz kalmadı.";
          Console.WriteLine(sonuc1);

         
          
          
        


        }
        
      
    }
    
}