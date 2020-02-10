namespace Jason5Lee.TaggedUnionPatterns.Case4
{
    public abstract partial class Shape 
    {
        internal Shape() {}
    }
    public partial class Circle : Shape
    {
        public double Radius { get; }
    }
    public partial class EquilateralTriangle : Shape
    {
        public double SideLen { get; }
    }
    public partial class Square : Shape
    {
        public double SideLen { get; }
    }
    public partial class Rectangle : Shape
    {
        public double Height { get; }
        public double Width { get; }
    }
}
