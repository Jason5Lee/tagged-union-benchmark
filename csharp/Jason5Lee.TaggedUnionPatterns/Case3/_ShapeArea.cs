using System;
namespace Jason5Lee.TaggedUnionPatterns.Case3
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
    partial class EquilateralTriangle
    {
        public override double AreaVirtual() =>
            Math.Sqrt(3.0) / 4.0 * SideLen * SideLen;
    }
    partial class Rectangle
    {
        public override double AreaVirtual() =>
            Height * Width;
    }
}
