using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yours number!");

            int result = int.Parse(Console.ReadLine());

            if(result % 2 == 0)
            {
                Console.WriteLine("This is Even Number!");
            }
            else
            {
                Console.WriteLine("This is Odd Number!");
            }

            Console.ReadLine();


        }
    }
}
