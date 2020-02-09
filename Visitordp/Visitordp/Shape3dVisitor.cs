using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public class Shape3dVisitor : IShapeVisitor
    {
        public float Visit(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public float Visit(Circle circle)
        {
            throw new NotImplementedException();
        }
    }
}
