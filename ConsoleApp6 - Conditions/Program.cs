using System;

namespace ConsoleApp6___Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND = &&
            var a = 10;
            var b = 0;

            if (a > b && a < 10 && a > 5 )
            {
                //Console.WriteLine("A");
            }
            else
            {
                //Console.WriteLine("B");
            }
          
            //OR = ||
            var c = 2;
            var d = 5;

            if ((c > d || c > 1) && a > 5)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }

            while(c > d || c > 1)
            {
                //Console.WriteLine("C");
                c--;
            }

            Console.ReadLine();
        }
    }
}