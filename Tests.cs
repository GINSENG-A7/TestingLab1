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
}
