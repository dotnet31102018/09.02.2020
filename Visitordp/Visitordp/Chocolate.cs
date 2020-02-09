using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public class Chocolate : ProductBase
    {
        public Chocolate(double price) : base(price)
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
