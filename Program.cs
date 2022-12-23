using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i < number2; i++)
            {
                int sum = 0;
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        sum = sum + x;                       
                    }
                }
                if (sum == i)
                {

                    Console.WriteLine(" the sum is" + i);
                }
            }
        }
    }
}
