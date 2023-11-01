using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class BinaryProgram
    {
        static void Main()
        {

            int _digit = 0;
            int _result = 0;
            string _binar = string.Empty;
            int _qua = 0;

            Console.WriteLine("Enter Your Number!");
            _digit = Convert.ToInt32(Console.ReadLine());



            while(_digit > 0)
            {

                _result = _digit % 2;
                _qua = _digit / 2;
                _digit = _qua;

                _binar += _result;

                


            }


            Console.WriteLine($"NumberBinaryDigits:{_binar}");
            Console.ReadLine();


        }
    }
}
