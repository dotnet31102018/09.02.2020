namespace Visitordp
{
    public class Tabacco : ProductBase
    {
        public Tabacco(double price) : base(price)
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