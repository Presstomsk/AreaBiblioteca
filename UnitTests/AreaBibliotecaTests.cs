using AreaBiblioteca.Abstractions;
using AreaBiblioteca.Models;

namespace UnitTests
{
    public class AreaBibliotecaTests
    {

        [TestCase(10)]
        public void Circle_GetAreaTest_TrueResult(double radius)
        {
            var testCircle = new Circle(radius);
            Assert.IsTrue(testCircle.GetArea() == 2 * Math.PI * Math.Pow(radius, 2));
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void Circle_GetAreaTest_ThrowResult(double radius)
        {
            var testCircle = new Circle(radius);            
            Assert.Throws<Exception>(() => testCircle.GetArea());
        }

        [TestCase(10, 10, 10)]
        public void Triangle_GetAreaTest_TrueResult(double a, double b, double c)
        {
            var testTriangle = new Triangle(a, b, c);
            var p = (a + b + c) / 2;
            Assert.IsTrue(testTriangle.GetArea() == Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        [TestCase(0, 10, 10)]
        [TestCase(10, 10, -2)]
        public void Triangle_GetAreaTest_ThrowResult(double a, double b, double c)
        {
            var testTriangle = new Triangle(a, b, c);
            Assert.Throws<Exception>(() => testTriangle.GetArea());
        }

        
        [TestCase(25, 24, 7)]
        public void Triangle_IsRectangularCheck_TruetResult(double a, double b, double c)
        {
            var testTriangle = new Triangle(a, b, c);
            Assert.IsTrue(testTriangle.IsRectangular());
        }

        [TestCase(25, 24, 6)]
        public void Triangle_IsRectangularCheck_FalseResult(double a, double b, double c)
        {
            var testTriangle = new Triangle(a, b, c);
            Assert.IsFalse(testTriangle.IsRectangular());
        }
        [TestCase(25, 24, -2)]
        public void Triangle_IsRectangularCheck_ThrowResult(double a, double b, double c)
        {
            var testTriangle = new Triangle(a, b, c);
            Assert.Throws<Exception>(() => testTriangle.IsRectangular());
        }

    }
}