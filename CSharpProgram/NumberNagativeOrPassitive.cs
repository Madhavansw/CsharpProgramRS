using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class NumberNagativeOrPassitive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number!");
            int _number = Convert.ToInt32(Console.ReadLine());

            if(_number < 0)
            {
                Console.WriteLine("Number is Nagative!");
            }
            else if(_number == 0)
            {
                Console.WriteLine("Number is Zero!");
            }

            else
            {
                Console.WriteLine("Number is passitive!");
            }

            Console.ReadLine();

        }
    }
}
