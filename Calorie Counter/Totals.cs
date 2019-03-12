using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    class Totals
    {
        static void Main(string[] args)
        {
            double F = 9;
            double C = 4;

            Console.WriteLine("What is the number of fat grams you consumed today?: ");
            double FG = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the number of carbohydrate grams you consumed today?: ");
            double CG = double.Parse(Console.ReadLine());


            double TF = GramTotal (FG, F);

            double TC = GramTotal (C,CG);

            double WT = GrandTotal (TF,TC);


            Console.WriteLine("Your total calories from fat are {0} ", TF);

            Console.WriteLine("Your total calories from carbohydrates are {0}", TC);

            Console.WriteLine("Your whole total of calories is {0}", WT);
            Console.ReadLine();
        }


       static double GrandTotal(double x, double y)
        {
            return x + y;
            
        }
        static double GramTotal( double x, double y)
        {
            return x * y;
        }
        }
    }

