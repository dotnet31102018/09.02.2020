using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public override double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }

        // public float CalcArea()
        //{
        //}


    }
}
