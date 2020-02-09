using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public class ShapeVisitor : IShapeVisitor
    {
        public float Visit(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public float Visit(Circle circle)
        {
            return (float)(circle.Radius * Math.PI * Math.PI);
        }
    }
}
