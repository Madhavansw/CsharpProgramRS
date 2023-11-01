using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class Convert_Decimal_to_Binary
    {
        static void Main(string[] agrs)
        {
            // my code 
            int _num;
            Console.WriteLine("Enter Number!");
            _num = int.Parse(Console.ReadLine());
            int _quot;
            string _rem = "";
            while(_num >= 1)
            {
                _quot = _num / 2;
                _rem += (_num % 2).ToString();
                _num = _quot;
            }
            Console.WriteLine($"result :{_rem}");

            string _bin = "";
            int index = 0;
            int _len = _rem.Length - 1;

            while( index <= _rem.Length -1)
            {
                _bin += _rem[_len];
                _len--;
                index++;

               
            }
            for(int i  = _rem.Length-1; i >=0; i--)
            {
                _bin += _rem[i];

            }

            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
            Console.Read();

        }
    }
}
