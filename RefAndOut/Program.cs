using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine("Before number 1 : " + number1);
            Referance(8, ref number1);
            Console.WriteLine("After number 3 : " + number1);

            Console.WriteLine("***************************************************");

            int number2;
            Out(out number2);
            Console.WriteLine("Before number 4 : " + number2);

            Console.WriteLine("***************************************************");

            int number3 = 5;
            int number4;

            RefAndOut(ref number3, out number4);
            Console.WriteLine("Before number 3 : " + number3);
            Console.WriteLine("Before number 4 : " + number4);

        }

        static void Referance(int number1, ref int number2)
        {
            number2 += number1;
        }

        static void Out(out int number1)
        {
            number1 =  6;
        }

        static void RefAndOut(ref int number1, out int number2)
        {
            number2 = 6;
            number1 += number2;
        }
    }
}
