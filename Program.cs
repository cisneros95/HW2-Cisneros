using System;


namespace HW2_Cisneros
{
    class Program
    {
        static void Main(string[] args)  ///This is very important Method
        {
            WriteAverage();     //Method Calls
            WriteAmerican();    //Method Calls
            WriteEuropean();    //Method Calls

        }

        // This is the method definition for WriteAverage
        static void WriteAverage()
        {
            double num1 = 2.0;
            double num2 = 7;
            Console.WriteLine((num1 + num2) / 2);
        }
        // This is the method definition for WriteAmerican
        static void WriteAmerican()
        {
            string day = "Saturday,";
            int date = (18);
            string month = "July";
            int year = (2020);
            Console.WriteLine(day + " " + month + " " + date + "," + " " + year);
        }

        // This is the method definition for WriteEuropean
        static void WriteEuropean()
        {
            string day = "Saturday";
            string month = "July";
            int date = (18);
            int year = (2020);
            Console.WriteLine(day + " " + date + " " + month + "," + " " + year); 

        }

    }
}
