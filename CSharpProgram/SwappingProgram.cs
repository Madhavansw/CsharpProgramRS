using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class SwappingProgram
    {
        static void Main()
        {

            int number1 = 0, number2 = 0 ;
            Console.WriteLine("Enter Numbe1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            /// using * and / 
            //number1 = number1 * number2;
            //number2 = number1 / number2;
            //number1 = number1 / number2;

            /// using + and - symbol
            /// 

            number1 = number1 + number2; // n1 = 10, n2 = 20
            number2 = number1 - number2;
            number1 = number1 - number2;

            
            Console.WriteLine("After swaping ");
            Console.WriteLine($"number1:{number1}");
            Console.WriteLine($"number2:{number2}");
            Console.ReadLine();
            

           


        }
    }
}
