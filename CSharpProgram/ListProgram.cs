using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class ListProgram
    {
       static  void Main()
        {


            var _list = new List<int>();
            _list.Add(20);
            _list.Add(200);
            _list.Add(501);
            _list.Add(205);
            _list.Add(706);
            _list.Add(605);

            var _min = _list
                .OrderBy(x => x)
                .FirstOrDefault();
            var _max = _list
                .OrderByDescending(x => x)
                .FirstOrDefault();
            var _firstTwoElement = _list
                                   .Select(x => x)
                                   .Take(2);
            var _lastTwoElement = _list
                                  .Select(x => x)
                                  .Skip(4);
            var _first4OfMax = _list
                               .Select(x => x)
                               .Take(4)
                               .OrderByDescending(x => x)
                               .FirstOrDefault();
            var _last4ofmax = _list
                              .Select(x => x)
                              .Skip(2)
                              .OrderByDescending(x => x)
                              .FirstOrDefault();







        
            Console.ReadLine();
          
            

        }
    }
}
