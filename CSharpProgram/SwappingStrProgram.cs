using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class SwappingStrProgram
    {
        static void Main()
        {

            string str1 = string.Empty;
            string str2 = string.Empty;
            string temp = string.Empty;

            Console.WriteLine("Please string str1");
            str1 = Console.ReadLine();
            Console.WriteLine("please enter Str2");
            str2 = Console.ReadLine();

            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");
            Console.WriteLine("After Swapping!");
            temp = str1;
            str1 = str2;
            str2 = temp;

            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");
            Console.ReadLine();

           
            






        }
    }
}
