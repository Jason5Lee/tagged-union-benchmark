using System;
namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    partial class Shape
    {
        public abstract double AreaVirtual();
    }
    partial class Circle
    {
        public override double AreaVirtual() =>
            Math.PI * Radius * Radius;
    }
    partial class Rectangle
    {
        public override double AreaVirtual() =>
            Height * Width;
    }
}
