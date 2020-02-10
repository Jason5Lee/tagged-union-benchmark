using System;

namespace Jason5Lee.TaggedUnionPatterns.Case2
{
    partial class Shape
    {
        public abstract void Visit(
            Action<Circle> circle, 
            Action<Rectangle> rectangle);
        public abstract TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<Rectangle, TResult> rectangle);
        
    }
    partial class Circle
    {
        public override void Visit(
            Action<Circle> circle,
            Action<Rectangle> rectangle)
        => circle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle, 
            Func<Rectangle, TResult> rectangle)
        => circle(this);
    }
    partial class Rectangle
    {
        public override void Visit(
            Action<Circle> circle, 
            Action<Rectangle> rectangle)
        => rectangle(this);

        public override TResult Visit<TResult>(
            Func<Circle, TResult> circle,
            Func<Rectangle, TResult> rectangle)
        => rectangle(this);
    }
}
