using System;

namespace LSP
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
            var VolumeComputation = new VolumeProcessor(shapes);
            var printWithFormat = new OutputFormatter(AreaComputation);
            printWithFormat.areaFormat1();
            printWithFormat.areaFormat2();
            var printWithFormatVol = new OutputFormatter(VolumeComputation);
            printWithFormatVol.areaFormat1();
            printWithFormatVol.areaFormat2();
        }
    }
}
