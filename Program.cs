using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Esc' to escape ;)");           

            ConsoleKeyInfo input;
            do
            {
              input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);
            
        }
    }
}