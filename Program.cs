using System;
using NUnit.Framework;

namespace TestingLab1
{
    [TestFixture]
    class FigureTest
    {
        Rectangle myRect = new Rectangle(7, 10);
        EquilateralTriangle myTriangle = new EquilateralTriangle(6);
        Circle myCircle = new Circle(4);
        Circle myCircle2 = new Circle(5);
        [Test]
        public void RectangleTestNo_1()
        {
            Assert.AreEqual(70, myRect.Surface());
        }
        [Test]
        public void RectangleTestNo_2()
        {
            Assert.AreEqual(48, myRect.Perimeter());
        }
        [Test]
        public void RectangleTestNo_3()
        {
            Assert.IsFalse(120 < myRect.Perimeter() + myRect.Surface()); //not valid
        }

        [Test]
        public void TriangleTestNo_1()
        {
            Assert.IsNotNull(myTriangle.Surface());
        }
        [Test]
        public void TriangleTestNo_2()
        {
            Assert.IsNotNull(myTriangle.Perimeter());
        }
        [Test]
        public void TriangleTestNo_3()
        {
            Assert.IsNotNull(myTriangle);  //not valid
        }

        [Test]
        public void CircleTestNo_1()
        {
            Assert.AreNotSame(myCircle.Surface(), myCircle.Perimeter());
        }
        [Test]
        public void CircleTestNo_2()
        {
            Assert.AreNotSame(myCircle, myCircle2); //not valid
        }
        [Test]
        public void CircleTestNo_3()
        {
            Assert.IsTrue(myCircle.Surface() > myCircle.Perimeter());
        }
    }

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
