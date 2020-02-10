using System;

namespace Jason5Lee.TaggedUnionPatterns
{
    partial class Shape
    {
        public abstract void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle);
        public abstract TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle);
    }
    partial class Circle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        => circle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        => circle(this);
    }

    partial class EquilateralTriangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        => equilateralTriangle(this);
        
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        => equilateralTriangle(this);
    }

    partial class Square
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        => square(this);
        
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        => square(this);
    }

    partial class Rectangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<EquilateralTriangle> equilateralTriangle,
            Action<Square> square,
            Action<Rectangle> rectangle)
        => rectangle(this);
        
        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<EquilateralTriangle, TResult> equilateralTriangle,
            Func<Square, TResult> square,
            Func<Rectangle, TResult> rectangle)
        => rectangle(this);
    }
}
