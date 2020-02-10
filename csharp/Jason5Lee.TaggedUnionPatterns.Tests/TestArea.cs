using System;
using Xunit;

namespace Jason5Lee.TaggedUnionPatterns.Tests
{
    public class TestArea
    {
        static (Shape circle, double area)[] expected = new(Shape, double)[]
        {
            (new Circle(1.0), Math.PI),
            (new Circle(Math.Sqrt(2.0)), 2.0 * Math.PI),
            (new Circle(2.0), 4.0 * Math.PI),
            (new EquilateralTriangle(1.0), Math.Sqrt(3) / 4),
            (new EquilateralTriangle(Math.Sqrt(Math.Sqrt(3.0))), 3.0 / 4.0),
            (new EquilateralTriangle(2.0), Math.Sqrt(3.0)),
            (new Square(1.0), 1.0),
            (new Square(Math.Sqrt(2.0)), 2.0),
            (new Square(Math.Sqrt(3.0)), 3.0),
            (new Square(2.0), 4.0),
            (new Rectangle(2.0, 3.0), 6.0),
            (new Rectangle(7.0, 5.0), 35.0)
        };
        const int Precision = 7;
        [Fact]
        void TestAreaSwitch()
        {
            foreach (var (circle, area) in expected)
            {
                Assert.Equal(area, circle.AreaSwitch(), Precision);
            }
        }
        [Fact]
        void TestAreaMatch()
        {
            foreach (var (circle, area) in expected)
            {
                Assert.Equal(area, circle.AreaMatch(), Precision);
            }
        }
        [Fact]
        void TestAreaMatchVoid()
        {
            foreach (var (circle, area) in expected)
            {
                Assert.Equal(area, circle.AreaMatchVoid(), Precision);
            }
        }
    }
}
