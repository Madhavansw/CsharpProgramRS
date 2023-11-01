using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class OddRange
    {
       static void  Main(string[] args)
        {

            IEnumerable<int> result = Enumerable
                             .Range(20, 20)
                             .Where(x => x % 2 != 0);
                     
            foreach(var number in result)
            {
                Console.WriteLine($"OddNumber:{number}");
            }

            Console.ReadLine();


        }
    }
}
