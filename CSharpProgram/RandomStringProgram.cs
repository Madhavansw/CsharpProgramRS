using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class RandomStringProgram
    {
        public static  Random _random = new Random();


        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var _result = Enumerable
                .Repeat(chars, 4)
                .Select(x => x[random.Next(x.Length)])
                .ToString();
            var _result2 = Enumerable
                .Repeat(20, 20)
                .Select(x => x+ 1)
                .ToArray();

            return _result;

           
        }
        static void Main()
        {

            RandomString(7);

            var _result = _random.Next(30);
            
      
        }
    }

}

    


