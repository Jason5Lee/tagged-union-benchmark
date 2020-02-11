using System;

namespace Jason5Lee.TaggedUnionPatterns.Case3
{
    public static class TagShapeExtension
    {
        public static double AreaSwitch(this TagShape s)
        {
            switch (s.Tag)
            {
                case ShapeCase.Circle:
                    return Math.PI * s.Radius * s.Radius;
                case ShapeCase.EquilateralTriangle:
                    return Math.Sqrt(3.0) / 4.0 * s.SideLen * s.SideLen;
                case ShapeCase.Rectangle:
                    return s.Height * s.Width;
                default:
                    throw new InvalidOperationException();
            }
        }

        public static double AreaMatch(this TagShape s) => 
            s.Match(
                radius => Math.PI * radius * radius,
                sideLen => Math.Sqrt(3.0) / 4.0 * sideLen * sideLen, 
                (height, width) => height * width);

        public static TagShape ToTagShape(this Shape s) =>
            s.Match(
                circle => TagShape.Circle(circle.Radius),
                triangle => TagShape.EquilateralTriangle(triangle.SideLen),
                rectangle => TagShape.Rectangle(rectangle.Height, rectangle.Width));
    }
}