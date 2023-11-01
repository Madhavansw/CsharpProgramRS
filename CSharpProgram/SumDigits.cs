using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class SumDigits
    {
        static void Main()
        {

            int _digit = 0;
            int _rem = 0;
            int _qua = 0;
            int _sum = 0;

            Console.WriteLine("Please Enter Number");
            _digit = int.Parse(Console.ReadLine());
            while(_digit != 0)
            {
                _rem = _digit % 10;
                _qua = _digit / 10;
                _digit = _qua;
                _sum += _rem;



            }

            Console.WriteLine($"SumofDigits:{_sum}");


            Console.ReadLine();




             

        }
    }
}
