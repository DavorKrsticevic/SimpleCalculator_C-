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
            try
            {
                //take user input and convert it from string to numerical
                InputConverter inputConverter = new InputConverter();
                //some type of calculator engine that will do the calc
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //get two input numbers
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                //get the result
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //in real world we would want to log this exception
                Console.WriteLine(ex.Message);
            }


        }   
    }
}
