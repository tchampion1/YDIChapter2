using static System.Console;

namespace Program 
{
    class DemoVariables 
    { 
        static void Main(string[] args)
        {
            int anInt = 2003453456;
            long signedLongInt = 123_456_789_000;
            uint anUnsignedInt = 567;
            sbyte anSignedbyt = -127;
            ushort anUnsignedShrt = 0;
            short anSignedShrt = -32_368;
            WriteLine("The int is {0}, the unsigned int is {1}, the signed long integer is {2} .", anInt, anUnsignedInt, signedLongInt);
            ReadLine();
        }
    }

}




