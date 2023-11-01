using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
   public class DigitPowerProgram
    {
        static void Main()
        {

            int _digit = 0;
            int _power = 0;
            int _result = 1;
            Console.WriteLine("Enter Numer!");
            _digit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Power!");
            _power = int.Parse(Console.ReadLine());

            while(_power >= 1)
            {
                _result *= _digit;
                _power--;



            }

            Console.WriteLine($"NumberPower:{_result}");
            Console.ReadLine();




        }
    }
}
