using System;

namespace TestingLab1
{
    //class Program
    //{
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Rectangle myRect = new Rectangle(7, 10);
        //        myRect.getName();
        //        Console.WriteLine("Площадь прямоугольника равна {0} ", myRect.Surface());
        //        Console.WriteLine("Периметр прямоугоьника равен {0} ", myRect.Perimeter());
        //        EquilateralTriangle myTriangle = new EquilateralTriangle(6);
        //        myTriangle.getName();
        //        Console.WriteLine("Площадь равностороннего треугоьника равна {0} ", myTriangle.Surface());
        //        Console.WriteLine("Периметр равностороннего треугольника равен {0} ", myTriangle.Perimeter());
        //        Circle myCircle = new Circle(4);
        //        myCircle.getName();
        //        Console.WriteLine("Площадь круга равна {0} ", myCircle.Surface());
        //        Console.WriteLine("Периметр круга равен {0} ", myCircle.Perimeter());
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    //}

    abstract class Figure
    {
        public abstract double Surface();
        public abstract double Perimeter();
        public abstract string getName();
    }
    class Rectangle : Figure
    {
        int width;
        int height;
        public Rectangle(int height, int width)
        {
            this.width = width;
            this.height = height;
        }
        public override string getName()
        {
            return "Прямоугольник";
        }
        public override double Surface()
        {
            double s = width * height;
            return s;
        }
        public override double Perimeter()
        {
            double p = 2 * width + 2 * height * 2;
            return p;
        }
    }
    class EquilateralTriangle : Figure
    {
        int length;
        public override string getName()
        {
            return "Равносторонний треугольник";
        }
        public EquilateralTriangle(int length)
        {
            this.length = length;
        }
        public override double Surface()
        {
            double s = Math.Pow(length, 2) * Math.Sqrt(3) / 4;
            return s;
        }
        public override double Perimeter()
        {
            double p = 3 * length;
            return p;
        }
    }
    class Circle : Figure
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override string getName()
        {
            return "Равносторонний треугольник";
        }
        public override double Surface()
        {
            double s = Math.PI * Math.Pow(radius, 2);
            return s;
        }
        public override double Perimeter()
        {
            double p = 2 * Math.PI * radius;
            return p;
        }
    }
}
