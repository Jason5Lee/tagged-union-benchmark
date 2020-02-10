using System;

namespace Jason5Lee.TaggedUnionPatterns.Case3
{
    partial class Shape
    {
        public abstract void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Rectangle> rectangle);
        public abstract TResult Visit<TResult>(
            Func<Circle, TResult> circle,
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Rectangle, TResult> rectangle);
        
    }
    partial class Circle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Rectangle> rectangle)
        => circle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Rectangle, TResult> rectangle)
        => circle(this);
    }

    partial class EquilateralTriangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Rectangle> rectangle)
        => equilateralTriangle(this);
        
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Rectangle, TResult> rectangle)
        => equilateralTriangle(this);
    }

    partial class Rectangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Rectangle> rectangle)
        => rectangle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Rectangle, TResult> rectangle)
        => rectangle(this);
    }
}
