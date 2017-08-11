using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = { "Scissors", "paper", "rock" };
            List<string> words = new List<string>
            {
                "Scissors",
                "paper",
                "rock"
            };

            var i = 0;
            //words.length when using an array
            while(i < words.Count)
            {
                Console.WriteLine(words[i]);
                //i = i + 1;
                i++;
            }
         
            Console.WriteLine("------------");

            for(var j = 0; j < words.Count; j++)
            {
                Console.WriteLine(words[j]);
            }

            Console.WriteLine("------------");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            
            Console.ReadLine();
            //   0           1         2
            //["paper", "Scissors", "rock"]
        }
    }
}