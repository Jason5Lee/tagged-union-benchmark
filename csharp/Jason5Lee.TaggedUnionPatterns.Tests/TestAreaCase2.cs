using System;
using Xunit;
using Jason5Lee.TaggedUnionPatterns.Case2;

namespace Jason5Lee.TaggedUnionPatterns.Tests
{
    using static Utils;
    public class TestAreaCase2
    {
        static (Shape shape, double area)[] expected = new(Shape, double)[]
        {
            (new Circle(1.0), Math.PI),
            (new Circle(Math.Sqrt(2.0)), 2.0 * Math.PI),
            (new Circle(2.0), 4.0 * Math.PI),
            (new Rectangle(2.0, 3.0), 6.0),
            (new Rectangle(7.0, 5.0), 35.0)
        };
        [Fact]
        void TestAreaSwitch()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaSwitch(), Precision);
            }
        }
        [Fact]
        void TestAreaMatch()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaMatch(), Precision);
            }
        }
        [Fact]
        void TestAreaMatchVoid()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaMatchVoid(), Precision);
            }
        }
        [Fact]
        void TestAreaVisit()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaVisit(), Precision);
            }
        }
        [Fact]
        void TestAreaVisitVoid()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaVisitVoid(), Precision);
            }
        }
        [Fact]
        void TestAreaVirtual()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.AreaVirtual(), Precision);
            }
        }
        [Fact]
        void TestTagAreaSwitch()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.ToTagShape().AreaSwitch(), Precision);
            }
        }
        [Fact]
        void TestTagAreaMatch()
        {
            foreach (var (shape, area) in expected)
            {
                Assert.Equal(area, shape.ToTagShape().AreaMatch(), Precision);
            }
        }
    }
}
