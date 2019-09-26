using System;

namespace TempApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = new Random().Next(0, 100);
            int number2 = new Random().Next(0, 100);
            int number3 = new Random().Next(0, 100);

            Console.WriteLine(number1,number2,number3);
            int number1;
            int number2;
            int number3;

            Console.WriteLine(GetMaxNumber(5,10,3)); 


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
        
    }
}
