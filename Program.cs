using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Cisneros
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteAverage();
            WriteEuropean();
            WriteAmerican();
        }


        static void WriteAverage()
        {
            double num1 = 2.0;
            double num2 = 7;
            Console.WriteLine((num1 + num2) / 2);
        }

        static void WriteAmerican()
        {
            string day = "Saturday";
            int date = (18);
            string month = "July";
            int year = (2020);
            Console.WriteLine(day + " " + month + " " + date + "," + " " + year);
        }


        static void WriteEuropean()
        {


            string day = "Saturday,";
            string month = "July";
            int date = (18);
            int year = (2020);
            Console.WriteLine(day + " " + date + " " + month + "," + " " + year); 

        }

    }
}
