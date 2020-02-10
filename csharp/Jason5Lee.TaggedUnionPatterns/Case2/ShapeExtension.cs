using System;
namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    public static class ShapeExtension
    {
        public static double AreaMatch(this Shape shape) =>
            shape.Match(
                c => Math.PI * c.Radius * c.Radius,
                r => r.Height * r.Width
            );
        public static double AreaMatchVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Match(
                c => { area = Math.PI * c.Radius * c.Radius; },
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
        public static double AreaSwitch(this Shape shape)
        {
            switch(shape)
            {
                case Circle c:
                    return Math.PI * c.Radius * c.Radius;
                case Rectangle r:
                    return r.Height * r.Width;
                default:
                    throw new Exception($"Unknown shape: {shape.GetType()}.");
            }
        }
        public static double AreaVisit(this Shape shape) =>
            shape.Visit(
                c => Math.PI * c.Radius * c.Radius,
                r => r.Height * r.Width
            );
        public static double AreaVisitVoid(this Shape shape)
        {
            double area = 0.0;
            shape.Visit(
                c => { area = Math.PI * c.Radius * c.Radius; },
                r => { area = r.Height * r.Width; }
            );
            return area;
        }
    }
}
