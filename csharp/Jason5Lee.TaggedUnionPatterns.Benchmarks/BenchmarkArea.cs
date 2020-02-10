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
            for (int i = 0; i < N; ++i)
            {
                switch (random.Next(4))
                {
                    case 0:
                        shapes[i] = new Circle(random.NextDouble());
                        break;
                    case 1:
                        shapes[i] = new EquilateralTriangle(random.NextDouble());
                        break;
                    case 2:
                        shapes[i] = new Square(random.NextDouble());
                        break;
                    default:
                        shapes[i] = new Rectangle(random.NextDouble(), random.NextDouble());
                        break;
                }
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
    }
}
