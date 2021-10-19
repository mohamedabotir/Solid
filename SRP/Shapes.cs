using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Circle {
        public double radius { private set; get; }
        public Circle(float radius)
        {
            this.radius = radius;
        }
    }
    class Square {
        public double length { private set; get; }
        public Square(float length)
        {
            this.length = length;
        }
    }
    class AreaProcessor
    {
        dynamic[] shapes;
        public AreaProcessor(dynamic []shapes)
        {
            this.shapes = shapes;
        }
        public double[] AreaCalculator() {
            double[] areas = new double[shapes.Length];
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    areas[i] = Math.PI * Math.Pow(shapes[i].radius, 2);
                }
                else if (shapes[i] is Square) {
                    areas[i] =  Math.Pow(shapes[i].length, 2);

                }
            }  
            return areas;
        }
        //This problem will solve it with move formats function in separate class
        public void areaFormat1() {
            foreach (var item in AreaCalculator())
            {
                Console.WriteLine("Area:{0}",item);
            }
        }
        public void areaFormat2() {
            Console.WriteLine();
            Console.Write("Areas:{");
            foreach (var item in AreaCalculator())
            {
                Console.Write(item+",");
            }
            Console.WriteLine("}");

        }

    }
    class AreaFormatter {
        AreaProcessor area;
        public AreaFormatter(AreaProcessor area)
        {
            this.area = area;
        }
        public void areaFormat1()
        {
            foreach (var item in area.AreaCalculator())
            {
                Console.WriteLine("Area:{0}", item);
            }
        }

        public void areaFormat2()
        {
            Console.WriteLine();
            Console.Write("Areas:{");
            foreach (var item in area.AreaCalculator())
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("}");

        }

    }
}
