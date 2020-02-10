using System;
using BenchmarkDotNet.Attributes;

namespace Jason5Lee.TaggedUnionPatterns.Benchmarks
{
    public class BenchmarkArea
    {
        private const int N = 100000;
        private readonly Shape[] shapes;
        private double area;
        
        public BenchmarkArea()
        {
            var random = new Random(42);
            shapes = new Shape[N];
            Func<Shape>[] shapeFactories = new Func<Shape>[]
            {
#if (CASE2 || CASE3 || CASE4)
                () => new Circle(random.NextDouble()),
#endif
#if (CASE3 || CASE4)
                () => new EquilateralTriangle(random.NextDouble()),
#endif
#if CASE4
                () => new Square(random.NextDouble()),
#endif
                () => new Rectangle(random.NextDouble(), random.NextDouble())
            };
            
            for (int i = 0; i < N; ++i)
            {
                shapes[i] = shapeFactories[random.Next(shapeFactories.Length)]();
            }
        }

        [Benchmark]
        public void AreaSwitch()
        {
            foreach (var s in shapes)
            {
                area = s.AreaSwitch();
            }
        }

        [Benchmark]
        public void AreaMatchVoid()
        {
            foreach (var s in shapes)
            {
                area = s.AreaMatchVoid();
            }
        }

        [Benchmark]
        public void AreaMatch()
        {
            foreach (var s in shapes)
            {
                area = s.AreaMatch();
            }
        }
        
        [Benchmark]
        public void AreaVisitVoid()
        {
            foreach (var s in shapes)
            {
                area = s.AreaVisitVoid();
            }
        }

        [Benchmark]
        public void AreaVisit()
        {
            foreach (var s in shapes)
            {
                area = s.AreaVisit();
            }
        }
        [Benchmark]
        public void AreaVirtual()
        {
            foreach (var s in shapes)
            {
                area = s.AreaVirtual();
            }
        }
    }
}
