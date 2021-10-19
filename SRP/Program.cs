using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
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
            #region before SRP  
            //AreaComputation.areaFormat1();
            //AreaComputation.areaFormat2();
            #endregion
            var printWithFormat = new AreaFormatter(AreaComputation);
            printWithFormat.areaFormat1();
            printWithFormat.areaFormat2();

        }
    }
}
