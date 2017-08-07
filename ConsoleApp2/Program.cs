using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output
            PrintLine("Type in a name that contains L");
           
            //Input
            string name = ReadLine();

            var nameContainsL = name.ToLower().Contains("l");
            
            //NOT = !
            while (!nameContainsL)
            {
                PrintLine("The name does NOT Contain L, try again");
                name = ReadLine();
                nameContainsL = name.ToLower().Contains("l");
            }
            PrintLine("You have type a name that Contains L");

            PrintLine("Press enter to exit...");

            ReadLine();
        }

        static void PrintLine(string whatToWrite)
        {
            Console.WriteLine(whatToWrite);
        }

        static string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}