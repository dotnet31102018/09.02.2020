using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public class Line : IProto<Line>
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public Line Clone()
        {
            Line result = new Line(P1.Clone(), P2.Clone());
            return result;

            //return (Line)this.MemberwiseClone(); // good only for value types
        }

        public override string ToString()
        {
            return $"P1 {P1} P2 {P2}";
        }
    }
}
