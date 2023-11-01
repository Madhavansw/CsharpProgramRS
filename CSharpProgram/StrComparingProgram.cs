using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
   public class StrComparingProgram
    {
        static void Main()
        {

            string str = "Hello";

            if (str.Equals("Hello"))
            {
                Console.WriteLine("String is Matched!");
            }
            else
            {
                Console.WriteLine("String is not Matched!");
            }

            if (!str.Equals("Hello"))
            {
                Console.WriteLine("String is not Matched!");
            }
            else
            {
                Console.WriteLine("String is Martched!");
            }



            if(str.CompareTo("Hello") == 0)
            {
                Console.WriteLine("String is Matched!");
            }
            else
            {
                Console.WriteLine("string doen't Matched!");
            }

            if(str.CompareTo("Hii") == 0)
            {
                Console.WriteLine("String isn't matched!");
            }

            else
            {
                Console.WriteLine("String is Matched!");
            }


            Console.ReadLine();

        }
    }
}
