using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.Divide(5, 0);

            Console.ReadKey();
        }
    }
}
