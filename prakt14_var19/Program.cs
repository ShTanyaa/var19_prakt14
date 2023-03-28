using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace prakt14_var19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecorativeDogs dog = new DecorativeDogs();
            dog.info();
            Console.WriteLine();
            dog.Info();
            Console.WriteLine();
            dog.Info();
        }
    }
}
