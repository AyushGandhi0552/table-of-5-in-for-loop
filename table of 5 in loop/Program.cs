using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_of_5_in_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i = i + 1) 
            {
                Console.WriteLine(i*5);
                Console.ReadKey();
            }
        }
    }
}
