using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    interface IShape {
        double area();
        double volume();
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

        public double volume()
        {
            return 4/3.0 * Math.PI* Math.Pow(radius, 3);
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

        public double volume()
        {
            return Math.Pow(length, 3);
        }
    }
    
    class VolumeProcessor :AreaProcessor {
        dynamic[] shapes; 
        public VolumeProcessor(dynamic[] shapes):base(shapes)
        {
            this.shapes = shapes;
        }
        public override double[] Calculator() {
            double[] volumes = new double[shapes.Length];
            dynamic shape;
            for (int i = 0; i < volumes.Length; i++)
            {
                shape = shapes[i];
                if (shape is IShape)
                    volumes[i] = shape.volume();
                else
                    throw new CalculatorProcessorInvalidShapeException();
            }
            return volumes;
        }
        
        }
    class AreaProcessor
    {
        dynamic[] shapes;
        public AreaProcessor(dynamic []shapes)
        {
            this.shapes = shapes;
        }
        public virtual double[]  Calculator() {
            double[] areas = new double[shapes.Length];
            dynamic shapeContainer ;
            for (int i = 0; i < shapes.Length; i++)
            {
                shapeContainer = shapes[i];
                if (shapeContainer is IShape)
                    areas[i] = shapeContainer.area();
                else
                throw new CalculatorProcessorInvalidShapeException();
            }  
            return areas;
        }
       

    }

    [Serializable]
    internal class CalculatorProcessorInvalidShapeException : Exception
    {
        public CalculatorProcessorInvalidShapeException()
        {
        }

        public CalculatorProcessorInvalidShapeException(string message) : base(message)
        {
        }

        public CalculatorProcessorInvalidShapeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CalculatorProcessorInvalidShapeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    class OutputFormatter {
        AreaProcessor area;
        public OutputFormatter(AreaProcessor area)
        {
            this.area = area;
        }
        public void areaFormat1()
        {
            foreach (var item in area. Calculator())
            {
                Console.WriteLine("Area:{0}", item);
            }
        }

        public void areaFormat2()
        {
            Console.WriteLine();
            Console.Write("Areas:{");
            foreach (var item in area. Calculator())
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("}");

        }

    }
}
