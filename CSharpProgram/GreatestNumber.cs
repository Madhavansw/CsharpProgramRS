using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
   public  class GreatestNumber
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number!");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine($"A is big Number {a}");
            }
            else
            {
                Console.WriteLine($" B is big Number!{b}");
            }


            Console.ReadLine();

        }
    }
}
