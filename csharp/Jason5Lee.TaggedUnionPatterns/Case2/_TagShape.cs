using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    partial class TagShape
    {
        private TagShape(ShapeCase tag, double radius, double height, double width)
        {
            Tag = tag;
            Radius = radius;
            Height = height;
            Width = width;
        }
        
        public static TagShape Circle(double radius)
            => new TagShape(ShapeCase.Circle, radius, 0.0, 0.0);
        
        public static TagShape Rectangle(double height, double width)
            => new TagShape(ShapeCase.Rectangle, 0.0, height, width);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResult Match<TResult>(OnCircle<TResult> circle,
            OnRectangle<TResult> rectangle)
        {
            switch (Tag)
            {
                case ShapeCase.Circle:
                    return circle(Radius);
                case ShapeCase.Rectangle:
                    return rectangle(Height, Width);
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
