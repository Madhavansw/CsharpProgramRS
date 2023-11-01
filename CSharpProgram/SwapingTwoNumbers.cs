using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class SwapingTwoNumbers
    {
       static void Main()
        {
            int a, b, temp;

            Console.WriteLine("Enter Number A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number B");
            b =  Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;

            b = temp;


            Console.WriteLine("After Swaping Number!");
            Console.WriteLine($"Number A:{a}");
            Console.WriteLine($"Number B: {b}");
            Console.ReadLine();

        }
    }
}
