
using System;
using stating System.Console;
namespace Sum_Exercise
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //Declare all input/output variables
            int num1, num2, sum, diff, prod, quo, rem;

            //Request all input, Read and Convert if needed and store input variables.

            WriteLine("Please enter your first number");



            //perform calculations if needed
            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
            quo = num1 / num2;
            rem = num1 % num2;


            //Display all output

            //WriteLine("The sum is " + sum);
            
            //WriteLine("The sum of " + num1 + " + " + num2 + " = " + sum);

            WriteLine(string.Format("The sum of {0} + {1} = {2}", num1, num2, num1 + num2));
            //WriteLine($"The sum of {num1} + {num2} = {sum}");

            WriteLine("The difference of {0} - {1} = {2}", num1, num2, diff);
            WriteLine("The product of {0} * {1} = {2}", num1, num2, diff);
            WriteLine("The quotient of {0} / {1} = {2}", num1, num2, diff);
            WriteLine("The remainder of {0} % {1} = {2}", num1, num2, diff);
            ReadKey();

        }
    }
}






page 97 excerse 9