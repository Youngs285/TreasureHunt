using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            string[,] grid = new string[5, 5];

            Console.WriteLine("Please enter a grid from left to right, top to bottom.");
            string gridinput = Console.ReadLine();



            while (true)
            {
                Console.WriteLine("Now enter your desired path to the treasure.");
                string path = Console.ReadLine();
                if (path == "u")
                {
                    y = y + 1;
                }
                if (path == "d")
                {
                    y = y - 1;
                }
                if (path == "l")
                {
                    x = x - 1;
                }
                if (path == "r")
                {
                    x = x + 1;
                }
                for (int i = 0; i < gridinput.Length; i++)
           {
                if (grid[i, i] == "*")
                {
                    Console.WriteLine("Your boat sunk!");
                }
                if (grid[i, i] == "X")
                {
                    Console.WriteLine("YOU FOUND TREASURE!!!");
                }

            }


            }








            
        }
    }
}
