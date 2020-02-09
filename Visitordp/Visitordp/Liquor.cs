namespace Visitordp
{
    public class Liquor : ProductBase
    {
        public Liquor(double price) : base(price)
        {
        }

        public override double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Chocolate price : {Price}";
        }
    }
}