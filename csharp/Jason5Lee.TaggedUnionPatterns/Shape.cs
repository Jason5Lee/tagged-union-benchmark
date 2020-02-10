namespace Jason5Lee.TaggedUnionPatterns
{
    public abstract partial class Shape 
    {
        internal Shape() {}
    }
#if (CASE2 || CASE3 || CASE4)
    public partial class Circle : Shape
    {
        public double Radius { get; }
    }
#endif
#if (CASE3 || CASE4)
    public partial class EquilateralTriangle : Shape
    {
        public double SideLen { get; }
    }
#endif
#if CASE4
    public partial class Square : Shape
    {
        public double SideLen { get; }
    }
#endif
    public partial class Rectangle : Shape
    {
        public double Height { get; }
        public double Width { get; }
    }
}
