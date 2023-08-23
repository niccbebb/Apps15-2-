using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Nicole Bebb 05/02/2022
    /// </summary>
    public static class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] choices = new string[]
            {
                "1. Distance Converter",
                "2. BMI Calculator"
            };

            ConsoleHelper.OutputTitle("Please select the application you wish to use");
            choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();

            }
            else if (choice == 2)
            {
                BMICalculator cal= new BMICalculator();
                cal.Run();
            }
        }
    }
}
