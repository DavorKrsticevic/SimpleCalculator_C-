using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int convertedInputToNumber;
            int.TryParse(input, out convertedInputToNumber);

            
            int result = 10 + 10 - 100 + 1000 - convertedInputToNumber;

            Console.WriteLine(result);


        }
    }
}
