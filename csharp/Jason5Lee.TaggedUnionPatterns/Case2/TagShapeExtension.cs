using System;

namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    public static class TagShapeExtension
    {
        public static double AreaSwitch(this TagShape s)
        {
            switch (s.Tag)
            {
                case ShapeCase.Circle:
                    return Math.PI * s.Radius * s.Radius;
                case ShapeCase.Rectangle:
                    return s.Height * s.Width;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static double AreaMatch(this TagShape s) => 
            s.Match(
                radius => Math.PI * radius * radius,
                (height, width) => height * width);

        public static TagShape ToTagShape(this Shape s) =>
            s.Match(
                circle => TagShape.Circle(circle.Radius),
                rectangle => TagShape.Rectangle(rectangle.Height, rectangle.Width));

    }
}