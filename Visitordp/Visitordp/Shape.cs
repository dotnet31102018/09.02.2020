using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public abstract class Shape : IShapeVisitable
    {
        public abstract double Accept(IShapeVisitor visitor);


    }
}
