using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
   public  class StrCopyProgram
    {
       static void Main()
        {

            string str1 = string.Empty;
            string str2 = string.Empty;

            Console.WriteLine("Enter st1 program!");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter St2 P!");
            str2 = Console.ReadLine();

            Console.WriteLine("Before string!");
            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");
            Console.WriteLine("After copy string!");
            str2 = string.Copy(str1);


        }
    }
}
