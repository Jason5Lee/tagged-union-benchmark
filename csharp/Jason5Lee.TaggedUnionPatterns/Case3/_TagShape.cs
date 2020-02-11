using System;
using System.Runtime.CompilerServices;

namespace Jason5Lee.TaggedUnionPatterns.Case3
{
    partial class TagShape
    {
        private TagShape(ShapeCase tag, double radius, double height, double width, double sideLen)
        {
            Tag = tag;
            Radius = radius;
            Height = height;
            Width = width;
            SideLen = sideLen;
        }
        
        public static TagShape Circle(double radius)
            => new TagShape(ShapeCase.Circle, radius, 0.0, 0.0, 0.0);
        
        public static TagShape EquilateralTriangle(double sideLen)
            => new TagShape(ShapeCase.EquilateralTriangle, 0.0, 0.0, 0.0, sideLen);
        
        public static TagShape Rectangle(double height, double width)
            => new TagShape(ShapeCase.Rectangle, 0.0, height, width, 0.0);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResult Match<TResult>(OnCircle<TResult> circle,
            OnEquilateralTriangle<TResult> equilateralTriangle,
            OnRectangle<TResult> rectangle)
        {
            switch (Tag)
            {
                case ShapeCase.Circle:
                    return circle(Radius);
                case ShapeCase.EquilateralTriangle:
                    return equilateralTriangle(SideLen);
                case ShapeCase.Rectangle:
                    return rectangle(Height, Width);
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
