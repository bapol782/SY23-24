using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);

            Console.WriteLine("1) Fl Oz \n2) Gills\n3)Pints\n4)Quarts\n5)Gallons\n6)tbsp\n7)tsp\n8)cups");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("\t" + liters * 33.814 + " fl oz");
                    break;
                case 2:
                    Console.WriteLine("\t" + liters * 8.454 + " Gills");
                    break;
                case 3:
                    Console.WriteLine("\t" + liters * 2.113 + " Pints");
                    break;
                case 4:
                    Console.WriteLine("\t" + liters * 1.057 + " Quarts");
                    break;
                case 5:
                    Console.WriteLine("\t" + liters * 3.785 + " Gallons");
                    break;
                case 6:
                    Console.WriteLine("\t" + liters * 67.628 + " Tablespoons");
                    break;
                case 7:
                    Console.WriteLine("\t" + liters * 202.9 + " Teaspoons");
                    break;
                case 8:
                    Console.WriteLine("\t" + liters * 4.227 + " Cups");
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
            Console.ReadLine();
        }
    }
}
