using static System.Console;


namespace DemoVariables3
{
    class DemoVariables3
    {
        static void Main(string[] args)
        {
            int comparisonValue = 4;
            bool isSixMore = 6 > comparisonValue;
            WriteLine("When comparisonValue is {0}, isSixmore is {1}", comparisonValue, isSixMore);
            comparisonValue = 6;
            isSixMore = 6 > comparisonValue;
            WriteLine("When comparisonValue is {0}, isSixmore is {1}", comparisonValue, isSixMore);
            ReadLine();
        }
    }
}
