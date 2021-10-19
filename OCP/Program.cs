using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] shapes =
            {
                new Square(5),
                new Circle(10),
                new Square(4)
            };
            var AreaComputation = new AreaProcessor(shapes);
           
            var printWithFormat = new AreaFormatter(AreaComputation);
            printWithFormat.areaFormat1();
            printWithFormat.areaFormat2();
        }
    }
}
