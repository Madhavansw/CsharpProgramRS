using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class SubStringProgram
    {
       static void Main()
        {

            string str = "Hello How are you? ";
            if (str.Contains("How") == true)
            {
                Console.WriteLine("This is contain in given string!");
            }
            else
            {
                Console.WriteLine("This is not Contains!");
            }

            if(str.Contains("Hello") == true)
            {
                Console.WriteLine("This is contains!");
            }
            else
            {
                Console.WriteLine("This is d n'nt contains");
            }


        }
    }
}
