using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class RandomResult
    {
        static void Main()
        {


            string str = "abcdefghijklmanopqrst";
            char[] _carr = new char[8];
            Random _random = new Random();
            for(int i = 0; i < _carr.Length; i++)
            {
                _carr[i] = str[_random.Next(_carr.Length)];

            }

            var _finlResult = new string(_carr);

            //var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //var stringChars = new char[8];
            //var random = new Random();

            //var _result = chars[random.Next(chars.Length)];

            //for (int i = 0; i < stringChars.Length; i++)
            //{
            //    stringChars[i] = chars[random.Next(chars.Length)];
            //}

            //var finalString = new String(stringChars);



        }
    }
}
