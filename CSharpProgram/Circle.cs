using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    class Circle : ShapesClass
    {

        int radius = 0;
        public Circle(int n)
        {
            radius = n;
        }


        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        static void Main( string[] args)
        {
            int r;
            Console.WriteLine("Enter the Radius :");
            r = int.Parse(Console.ReadLine());
            Circle c1 = new Circle(r);
            Console.WriteLine("Area of the Circle = {0}", c1.Area());
            Console.ReadLine();

        }
    }
}
