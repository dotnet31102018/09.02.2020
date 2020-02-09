using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public abstract class ProductBase : IVisitable
    {
        public double Price { get; set; }

        protected ProductBase(double price)
        {
            Price = price;
        }

        public abstract double Accept(IVisitor visitor);
    }
}
