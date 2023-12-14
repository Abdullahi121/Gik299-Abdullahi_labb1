using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmitConsoleApp1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            // Delartion av variabler för namnen och ålderna på familje medlammerna
            String Name1;
            String Name2;
            String Name3;
            String Name4;
            int age1;
            int age2;
            int age3;
            int age4;

            //Läser in namnet på första personen från användaren, samma sak längre ner med ålder också
            Console.WriteLine("Vad är namnet på första personen:");
            Name1 = Console.ReadLine();
            

            Console.WriteLine("Hur gammal är första personen:");
            age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad är namnet på anrda personen:");
            Name2 = Console.ReadLine();

            Console.WriteLine("Hur gammal är andra personen:");
            age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad är namnet på tredje personen:");
            Name3 = Console.ReadLine();
            Console.WriteLine("Hur gammal är tredje personen:");
            age3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Vad är namnet på fjärde personen:");
            Name4 = Console.ReadLine();
            Console.WriteLine("Hur gamal är fjärde personen:");
            age4 = Convert.ToInt32(Console.ReadLine());

            // Skriver ut ålder och namn för alla fyra personer
            Console.WriteLine(Name1 + " är " + age1 + " år gammal");
            Console.WriteLine(Name2 + " är " + age2 + " år gammal");
            Console.WriteLine(Name3 + " är " + age3 + " år gammal");
            Console.WriteLine(Name4 + " är " + age4 + " år gammal");

            // Beräknar totalåldern för alla fyra personer
            double summanage = age1 + age2 + age3 + age4;
            double medelolder = summanage / 4;

            //Skriver ut totalådern och medelålder
            Console.WriteLine("Totalåldern " + summanage);
            Console.WriteLine("Medelålder " + medelolder.ToString("0.00"));
            Console.ReadLine(); 
            
            
            



        }

    }
}