using static System.Console;

namespace DemoVariables2
{
     class DemoVariables2
    {
        static void Main(string[] args)
        {
            int value1 = 22, value2 = 10, value3, value4, value5, value6, value7;
            int sum = value1 + value2, diff = value1 - value2, product = value1 * value2, quotient = value1 / value2, 
                remainder = value1 % value2;

            WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
            WriteLine("The differnce between {0} and {1} is {2}", value1, value2, diff);
            WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
            WriteLine("{0} divided by {1} is {2}", value1, value2, quotient);
            WriteLine("and the remainder is {0}", remainder);
            ReadLine();
         
        }
    }
}
