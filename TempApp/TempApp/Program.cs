using System;

namespace TempApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxNumber(5,10,3));

            Console.WriteLine(GetInRange(5, 1, 10));
        }

        static int GetMaxNumber(int number1, int number2, int number3)
        {
           
            if (number1>number2 && number1 > number3)
            {
               return number1;
            }
            else if (number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        
        }

        static bool GetInRange (int nr1, int from, int to)
        {
            return nr1 >= from && nr1<=to;
            
        }

        
    }
}
