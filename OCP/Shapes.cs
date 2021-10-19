using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    interface IShape {
        double area();
    }
    class Circle : IShape {
        public double radius { private set; get; }
        public Circle(float radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    class Square : IShape {
        public double length { private set; get; }
        public Square(float length)
        {
            this.length = length;
        }

        public double area()
        {
            return Math.Pow(length, 2);
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
            dynamic shapeContainer ;
            for (int i = 0; i < shapes.Length; i++)
            {
                shapeContainer = shapes[i];
                if (shapeContainer is IShape)
                    areas[i] = shapeContainer.area();
                 
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
