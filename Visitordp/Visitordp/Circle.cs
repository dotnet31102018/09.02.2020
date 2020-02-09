namespace Visitordp
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        // public float CalcArea()
        //{
        //}
        public override double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}