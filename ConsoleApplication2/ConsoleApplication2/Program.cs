using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
                    
            }
            Console.ReadLine();
        }
    }

   
}
