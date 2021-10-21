using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspereTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studNaam;
            int engelsPunt;
            int proNetw;
            int sum=0;
           
            Console.WriteLine("Enter the name");
            studNaam = (Console.ReadLine());
            Console.WriteLine("Enter the English value");
            engelsPunt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Programatie value");
            proNetw = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(studNaam + "Total Punt" + sum);
                
                sum = engelsPunt + proNetw;
            }
            while (engelsPunt >= 5 && engelsPunt <= 10);
            while (proNetw >= 5 && proNetw <= 10);

        }
    }
}
